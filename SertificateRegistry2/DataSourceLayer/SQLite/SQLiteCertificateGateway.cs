using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// правление объектами Certificate в базе данных SQLite
    /// </summary>
    public class SQLiteCertificateGateway: ICertificatesGateway
    {
        private SQLiteConnection connection;

        public SQLiteCertificateGateway(DbConnection Connection)
        {
            connection = Connection as SQLiteConnection;
        }

        /// <summary>
        /// Добавить сертификат
        /// </summary>
        /// <param name="Name">Название сертификата</param>
        /// <param name="Number">Номер сертификата</param>
        /// <param name="BeginDate">Дата выдачи</param>
        /// <param name="EndDate">Дата завершения</param>
        /// <param name="OrganizationId">Идентификатор организации</param>
        /// <returns>Идентификатор добавленного сертификата</returns>
        public int AddCertificate(string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId)
        {
            SQLiteCommand Command = new SQLiteCommand(@"INSERT INTO certificates (name, number, date_begin, date_end, id_organization)
                                                        VALUES(@name, @number, @date_begin, @date_end, @id_organization);
                                                        SELECT last_insert_rowid();",
                                                      connection);

            Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;
            Command.Parameters.Add("@number", DbType.AnsiString).Value = Number;
            Command.Parameters.Add("@date_begin", DbType.Date).Value = BeginDate;
            Command.Parameters.Add("@date_end", DbType.Date).Value = EndDate;
            Command.Parameters.Add("@id_organization", DbType.Int32).Value = OrganizationId;

            return Convert.ToInt32(Command.ExecuteScalar());
        }

        /// <summary>
        /// Изменить сертификат
        /// </summary>
        /// <param name="CertificateId">Идентификатор сертификата</param>
        /// <param name="Name">Название сертификата</param>
        /// <param name="Number">Номер сертификата</param>
        /// <param name="BeginDate">Дата выдачи</param>
        /// <param name="EndDate">Дата завершения</param>
        /// <param name="OrganizationId">Идентификатор организации</param>
        public void EditCertificate(int CertificateId, string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId)
        {
            SQLiteCommand Command = new SQLiteCommand(@"UPDATE certificates
                                                           SET name = @name,
                                                               number = @number,
                                                               date_begin = @date_begin,
                                                               date_end = @date_end,
                                                               id_organization = @id_organization
                                                         WHERE id = @id",
                                                         connection);

            Command.Parameters.Add("@id", DbType.Int32).Value = CertificateId;
            Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;
            Command.Parameters.Add("@number", DbType.AnsiString).Value = Number;
            Command.Parameters.Add("@date_begin", DbType.Date).Value = BeginDate;
            Command.Parameters.Add("@date_end", DbType.Date).Value = EndDate;
            Command.Parameters.Add("@id_organization", DbType.Int32).Value = OrganizationId;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удалить сертификат
        /// </summary>
        /// <param name="CertificateId">Идентификатор сертификата</param>
        public void DeleteCertificate(int CertificateId)
        {
            SQLiteCommand Command = new SQLiteCommand(@"DELETE FROM certificates
                                                        WHERE id = @id",
                                                        connection);

            Command.Parameters.Add("@id", DbType.Int32).Value = CertificateId;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Получить список сертификатов
        /// </summary>
        /// <returns>Список объектов класса Certificate</returns>
        public List<Certificate> GetCertificatesRegistry()
        {
            var CertificatesRegistry = new List<Certificate>();
            SQLiteCommand Command = new SQLiteCommand(@"SELECT c.id,
                                                               c.name,
                                                               c.number,
                                                               c.date_begin,
                                                               c.date_end,
                                                               o.name
                                                          FROM certificates c
                                                          JOIN organizations o on c.id_organization = o.id",
                                                          connection);

            SQLiteDataReader dr = Command.ExecuteReader();

            while (dr.Read())
            {
                CertificatesRegistry.Add(new Certificate(dr.GetInt32(0),
                                                            dr.GetString(1),
                                                            dr.GetString(2),
                                                            dr.GetDateTime(3),
                                                            dr.GetDateTime(4),
                                                            dr.GetString(5)));
            }

            dr.Close();

            return CertificatesRegistry;
        }
    }
}