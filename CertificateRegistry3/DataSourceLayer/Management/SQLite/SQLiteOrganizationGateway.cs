using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Управление объектами Organization в базе данных SQLite
    /// </summary>
    public class SQLiteOrganizationGateway : IOrganizationGateway
    {
        private SQLiteConnection connection;

        public SQLiteOrganizationGateway(DbConnection Connection)
        {
            connection = Connection as SQLiteConnection;
        }

        /// <summary>
        /// Добавить организацию
        /// </summary>
        /// <param name="Name">название организации</param>
        public int AddOrganization(string Name)
        {
            SQLiteCommand Command = new SQLiteCommand(@"INSERT INTO organizations (name)
                                                        VALUES(@name);
                                                        SELECT last_insert_rowid();",
                                                        connection);

            Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;

            return Convert.ToInt32(Command.ExecuteScalar());
        }
    
        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="ID_Organization">идентификатор организации</param>
        public void DeleteOrganization(int ID_Organization)
        {
            SQLiteCommand Command = new SQLiteCommand(@"DELETE FROM organizations
                                                        WHERE id = @id",
                                                        connection);

            Command.Parameters.Add("@id", DbType.Int32).Value = ID_Organization;

            Command.ExecuteNonQuery();
        }
        
        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>массив записей OrganizationListItem</returns>
        public List<Organization> GetOrganizationList()
        {
            var OrganizationList = new List<Organization>();

            SQLiteCommand Command = new SQLiteCommand(@"SELECT id, name FROM organizations",
                                                        connection);

            SQLiteDataReader dr = Command.ExecuteReader();
            while (dr.Read())
            {
                OrganizationList.Add(new Organization(ID_Organization: dr.GetInt32(0), 
                                                        Name: dr.GetString(1)));
            }
            dr.Close();

            return OrganizationList;
        }
    }
}
