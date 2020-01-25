using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Управление объектами Certificate в базе данных PostgreSQL
    /// </summary>
    public class PostgreSQLCertificateGateway : ICertificatesGateway
    {
        private NpgsqlConnection connection;

        public PostgreSQLCertificateGateway(DbConnection Connection)
        {
            connection = Connection as NpgsqlConnection;
        }

        /// <summary>
        /// Добавить сертификат
        /// </summary>
        /// <param name="Name">название сертификата</param>
        /// <param name="Number">номер сертификата</param>
        /// <param name="BeginDate">дата выдачи</param>
        /// <param name="EndDate">дата завершения</param>
        /// <param name="OrganizationId">идентификатор организации</param>
        /// <returns>идентификатор добавленного сертификата</returns>
        public int AddCertificate(string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId)
        {
            NpgsqlCommand Command = new NpgsqlCommand("certificate_add", connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Varchar;
            Command.Parameters[0].Value = Name;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[1].NpgsqlDbType = NpgsqlDbType.Varchar;
            Command.Parameters[1].Value = Number;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[2].NpgsqlDbType = NpgsqlDbType.Date;
            Command.Parameters[2].Value = BeginDate;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[3].NpgsqlDbType = NpgsqlDbType.Date;
            Command.Parameters[3].Value = EndDate;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[4].NpgsqlDbType = NpgsqlDbType.Integer;
            Command.Parameters[4].Value = OrganizationId;

            Object Result = Command.ExecuteScalar();
            return Convert.ToInt32(Result);
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
            NpgsqlCommand Command = new NpgsqlCommand("certificate_edit", connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Integer;
            Command.Parameters[0].Value = CertificateId;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[1].NpgsqlDbType = NpgsqlDbType.Varchar;
            Command.Parameters[1].Value = Name;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[2].NpgsqlDbType = NpgsqlDbType.Varchar;
            Command.Parameters[2].Value = Number;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[3].NpgsqlDbType = NpgsqlDbType.Date;
            Command.Parameters[3].Value = BeginDate;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[4].NpgsqlDbType = NpgsqlDbType.Date;
            Command.Parameters[4].Value = EndDate;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[5].NpgsqlDbType = NpgsqlDbType.Integer;
            Command.Parameters[5].Value = OrganizationId;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удалить сертификат
        /// </summary>
        /// <param name="CertificateId">Идентификатор сертификата</param>
        public void DeleteCertificate(int CertificateId)
        {
            NpgsqlCommand Command = new NpgsqlCommand("certificate_delete", connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new NpgsqlParameter());
            Command.Parameters[0].NpgsqlDbType = NpgsqlDbType.Integer;
            Command.Parameters[0].Value = CertificateId;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Получить список сертификатов
        /// </summary>
        /// <returns>Список объектов класса Certificate</returns>
        public List<Certificate> GetCertificatesRegistry()
        {
            var CertificatesRegistry = new List<Certificate>();

            NpgsqlCommand Command = new NpgsqlCommand("certificate_get_registry", connection);
            Command.CommandType = CommandType.StoredProcedure;            

            NpgsqlDataReader dr = Command.ExecuteReader();

            while (dr.Read())
            {
                var CurrentCertificateRecord = new Certificate(CertificateId: dr.GetInt32(0),
                                                                Name: dr.GetString(1),
                                                                Number: dr.GetString(2),
                                                                BeginDate: dr.GetDateTime(3),
                                                                EndDate: dr.GetDateTime(4),
                                                                OrganizationName: dr.GetString(5));

                CertificatesRegistry.Add(CurrentCertificateRecord);
            }

            dr.Close();

            return CertificatesRegistry;
        }
    }
}