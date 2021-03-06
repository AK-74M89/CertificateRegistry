﻿using System.Collections.Generic;
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
        private readonly SQLiteConnection connection;

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
            using (var Command = new SQLiteCommand(connection))
            {
                Command.CommandText = @"INSERT INTO organizations (name)
                                        VALUES(@name);
                                        SELECT last_insert_rowid();";
                Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;

                return (int)Command.ExecuteScalar();
            }
        }

        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="ID_Organization">идентификатор организации</param>
        public void DeleteOrganization(int ID_Organization)
        {
            using (var Command = new SQLiteCommand(connection))
            {
                Command.CommandText = @"DELETE FROM organizations WHERE id = @id";
                Command.Parameters.Add("@id", DbType.Int32).Value = ID_Organization;

                Command.ExecuteNonQuery();
            }
        }
        
        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>массив записей OrganizationListItem</returns>
        public List<Organization> GetOrganizationList()
        {
            using (var Command = new SQLiteCommand(connection))
            {
                Command.CommandText = @"SELECT id, name FROM organizations";

                var OrganizationList = new List<Organization>();

                var dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    OrganizationList.Add(new Organization(ID_Organization: dr.GetInt32(0), Name: dr.GetString(1)));
                }
                dr.Close();

                return OrganizationList;
            }
        }

        /// <summary>
        /// Изменить организацию
        /// </summary>
        /// <param name="OrganizationId">Идентификатор организации</param>
        /// <param name="Name">Новое название организации</param>
        public void EditOrganization(int OrganizationId, string Name)
        {
            using (var Command = new SQLiteCommand(connection))
            {
                Command.CommandText = @"UPDATE organizations
                                            SET name = @name
                                        WHERE id = @id";
                Command.Parameters.Add("@id", DbType.Int32).Value = OrganizationId;
                Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;

                Command.ExecuteNonQuery();
            }
        }

        public bool CanDelete(int OrganizationId)
        {
            using (SQLiteCommand Command = new SQLiteCommand(connection))
            {
                Command.CommandText = @"SELECT count(*)
                                        FROM certificate c
                                        WHERE c.id_organization = @id";
                Command.Parameters.Add("@id", DbType.Int32).Value = OrganizationId;

                return (int)Command.ExecuteScalar() == 0;
            }
        }
    }
}
