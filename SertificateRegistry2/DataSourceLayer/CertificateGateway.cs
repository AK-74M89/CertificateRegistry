using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;

namespace SertificateRegistry2.DataSourceLayer
{
    public static class CertificateGateway
    {       
        /// <summary>
        /// Добавить сертификат
        /// </summary>
        /// <param name="Name">название сертификата</param>
        /// <param name="Number">номер сертификата</param>
        /// <param name="Begin">дата выдачи</param>
        /// <param name="End">дата завершения</param>
        /// <param name="ID_Organization">идентификатор организации</param>
        public static void AddCertificate(string Name, string Number, DateTime Begin, DateTime End, int ID_Organization)
        {
            SQLiteCommand Command = new SQLiteCommand(@"INSERT INTO certificates (name, number, date_begin, date_end, id_organization)
                                                        VALUES(@name, @number, @date_begin, @date_end, @id_organization)", 
                                                      DBConnectionHandler.Connection);

            Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;
            Command.Parameters.Add("@number", DbType.AnsiString).Value = Number;
            Command.Parameters.Add("@date_begin", DbType.Date).Value = Begin;
            Command.Parameters.Add("@date_end", DbType.Date).Value = End;
            Command.Parameters.Add("@id_organization", DbType.Int32).Value = ID_Organization;

            Command.ExecuteNonQuery();            
        }

        /// <summary>
        /// Изменить сертификат
        /// </summary>
        /// <param name="ID_Certificate">идентификатор сертификата</param>
        /// <param name="Name">название сертификата</param>
        /// <param name="Number">номер сертификата</param>
        /// <param name="Begin">дата выдачи</param>
        /// <param name="End">дата завершения</param>
        /// <param name="ID_Organization">идентификатор организации</param>
        public static void EditCertificate(int ID_Certificate, string Name, string Number, DateTime Begin, DateTime End, int ID_Organization)
        {
            SQLiteCommand Command = new SQLiteCommand(@"UPDATE certificates
                                                           SET name = @name,
                                                               number = @number,
                                                               date_begin = @date_begin,
                                                               date_end = @date_end,
                                                               id_organization = @id_organization
                                                         WHERE id = @id", DBConnectionHandler.Connection);

            Command.Parameters.Add("@id", DbType.Int32).Value = ID_Certificate;
            Command.Parameters.Add("@name", DbType.AnsiString).Value = Name;
            Command.Parameters.Add("@number", DbType.AnsiString).Value = Number;
            Command.Parameters.Add("@date_begin", DbType.Date).Value = Begin;
            Command.Parameters.Add("@date_end", DbType.Date).Value = End;
            Command.Parameters.Add("@id_organization", DbType.Int32).Value = ID_Organization;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Удалить сертификат
        /// </summary>
        /// <param name="ID_Certificate">идентификатор сертификата</param>
        public static void DeleteCertificate(int ID_Certificate)
        {
            SQLiteCommand Command = new SQLiteCommand(@"DELETE FROM certificates
                                                        WHERE id = @id", DBConnectionHandler.Connection);

            Command.Parameters.Add("@id", DbType.Int32).Value = ID_Certificate;

            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Получить список сертификатов
        /// </summary>
        /// <returns>массив записей CertificatesListItem</returns>
        public static BindingList<CertificatesListItem> GetCertificatesRegistry()
        {
            BindingList<CertificatesListItem> CertificatesRegistry = new BindingList<CertificatesListItem>();
            SQLiteCommand Command = new SQLiteCommand(@"SELECT c.id,
                                                               c.name,
                                                               c.number,
                                                               c.date_begin,
                                                               c.date_end,
                                                               o.name
                                                          FROM certificates c
                                                          JOIN organizations o on c.id_organization = o.id", DBConnectionHandler.Connection);

            SQLiteDataReader dr = Command.ExecuteReader();

            while (dr.Read())
            {                
                CertificatesRegistry.Add(new CertificatesListItem(  dr.GetInt32(0), 
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