using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Управление объектами Organization в базе данных PostgreSQL
    /// </summary>
    public class PostgreSQLOrganizationGateway: IOrganizationGateway
    {
        private NpgsqlConnection connection;

        public PostgreSQLOrganizationGateway(DbConnection Connection)
        {
            connection = Connection as NpgsqlConnection;
        }

        /// <summary>
        /// Добавить организацию
        /// </summary>
        /// <param name="Name">Название организации</param>
        /// <returns>Идентификатор добавленной организации</returns>
        public int AddOrganization(string Name)
        {
            NpgsqlCommand Command = new NpgsqlCommand("organization_add", connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Varchar;
            Command.Parameters[0].Value = Name;            

            Object Result = Command.ExecuteScalar();
            return Convert.ToInt32(Result);
        }
    
        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="OrganizationId">Идентификатор организации</param>
        public void DeleteOrganization(int OrganizationId)
        {
            NpgsqlCommand Command = new NpgsqlCommand("organization_delete", connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Integer;
            Command.Parameters[0].Value = OrganizationId;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>Список объектов класса Organization</returns>
        public List<Organization> GetOrganizationList()
        {
            var OrganizationList = new List<Organization>();

            NpgsqlCommand Command = new NpgsqlCommand("organization_get_all", connection);
            Command.CommandType = CommandType.StoredProcedure;

            NpgsqlDataReader dr = Command.ExecuteReader();

            while (dr.Read())
            {
                var CurrentOrganizationRecord = new Organization(ID_Organization: dr.GetInt32(0),
                                                                    Name: dr.GetString(1)); 

                OrganizationList.Add(CurrentOrganizationRecord);
            }

            dr.Close();

            return OrganizationList;
        }
    }
}
