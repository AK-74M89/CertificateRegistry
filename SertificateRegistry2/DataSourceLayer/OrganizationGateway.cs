using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SertificateRegistry2.DataSourceLayer
{
    public static class OrganizationGateway
    {
        /// <summary>
        /// Добавить организацию
        /// </summary>
        /// <param name="Name">название организации</param>
        public static void AddOrganization(string Name)
        {
            SQLiteCommand Command = new SQLiteCommand(@"INSERT INTO organizations (name)
                                                        VALUES(@name)", DBConnectionHandler.Connection);

            Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;

            Command.ExecuteNonQuery();
        }
    
        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="ID_Organization">идентификатор организации</param>
        public static void DeleteOrganization(int ID_Organization)
        {
            SQLiteCommand Command = new SQLiteCommand(@"DELETE FROM organizations
                                                        WHERE id = @id", DBConnectionHandler.Connection);

            Command.Parameters.Add("@id", DbType.Int32).Value = ID_Organization;

            Command.ExecuteNonQuery();
        }
        
        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>массив записей OrganizationListItem</returns>
        public static IList<OrganizationListItem> GetOrganizationList()
        {
            IList<OrganizationListItem> OrganizationList = new List<OrganizationListItem>();

            SQLiteCommand Command = new SQLiteCommand(@"SELECT id, name FROM organizations", DBConnectionHandler.Connection);

            SQLiteDataReader dr = Command.ExecuteReader();
            while (dr.Read())
            {
                OrganizationList.Add(new OrganizationListItem(dr.GetInt32(0), dr.GetString(1)));
            }
            dr.Close();

            return OrganizationList;
        }
    }
}
