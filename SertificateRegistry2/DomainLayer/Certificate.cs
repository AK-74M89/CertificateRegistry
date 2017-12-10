﻿using SertificateRegistry2.DataSourceLayer;
using System;
using System.ComponentModel;

namespace SertificateRegistry2.DomainLayer
{
    class Certificate
    {
        private void CheckCertificateFields(string Name, string Number, DateTime Begin, DateTime End)
        {
            if (!Checker.CheckRegularString(Name))
            {
                throw (new DomainException("Длина названия должна быть менее 255 символов"));
            }
            if (!Checker.CheckRegularString(Number))
            {
                throw (new DomainException("Длина номера должна быть менее 255 символов"));
            }
            if (Begin > End)
            {
                throw (new DomainException("Дата выдачи сертификата должна быть меньше даты завершения"));
            }
        }

        /// <summary>
        /// Добавить сертификат
        /// </summary>
        /// <param name="Name">название сертификата</param>
        /// <param name="Number">номер сертификата</param>
        /// <param name="Begin">дата выдачи</param>
        /// <param name="End">дата завершения</param>
        /// <param name="ID_Organization">идентификатор организации</param>
        public void AddCertificate(string Name, string Number, DateTime Begin, DateTime End, int ID_Organization)
        {
            CheckCertificateFields(Name, Number, Begin, End);
            CertificateGateway.AddCertificate(Name, Number, Begin, End, ID_Organization);
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
        public void EditCertificate(int ID_Certificate, string Name, string Number, DateTime Begin, DateTime End, int ID_Organization)
        {
            CheckCertificateFields(Name, Number, Begin, End);
            CertificateGateway.EditCertificate(ID_Certificate, Name, Number, Begin, End, ID_Organization);
        }

        /// <summary>
        /// Удалить сертификат
        /// </summary>
        /// <param name="ID_Certificate">идентификатор сертификата</param>
        public void DeleteCertificate(int ID_Certificate)
        {
            CertificateGateway.DeleteCertificate(ID_Certificate);
        }

        /// <summary>
        /// Получить список сертификатов
        /// </summary>
        /// <returns>массив записей CertificatesListItem</returns>
        public BindingList<CertificatesListItem> GetCertificatesRegistry()
        {
            return CertificateGateway.GetCertificatesRegistry();
        }
    }
}
