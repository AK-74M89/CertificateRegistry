using CertificateRegistry3.DataSourceLayer;
using System;
using System.ComponentModel;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Бизнес-логика работы с сертификатами
    /// </summary>
    public class CertificateManager
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
        /// <param name="BeginDate">дата выдачи</param>
        /// <param name="EndDate">дата завершения</param>
        /// <param name="OrganizationId">идентификатор организации</param>
        public void AddCertificate(string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId)
        {
            CheckCertificateFields(Name, Number, BeginDate, EndDate);
            DBConnectionHandler.CertificatesGateway.AddCertificate(Name, Number, BeginDate, EndDate, OrganizationId);
        }

        /// <summary>
        /// Изменить сертификат
        /// </summary>
        /// <param name="CertificateId">идентификатор сертификата</param>
        /// <param name="Name">название сертификата</param>
        /// <param name="Number">номер сертификата</param>
        /// <param name="BeginDate">дата выдачи</param>
        /// <param name="EndDate">дата завершения</param>
        /// <param name="OrganizationId">идентификатор организации</param>
        public void EditCertificate(int CertificateId, string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId)
        {
            CheckCertificateFields(Name, Number, BeginDate, EndDate);
            DBConnectionHandler.CertificatesGateway.EditCertificate(CertificateId, Name, Number, BeginDate, EndDate, OrganizationId);
        }

        /// <summary>
        /// Удалить сертификат
        /// </summary>
        /// <param name="CertificateId">идентификатор сертификата</param>
        public void DeleteCertificate(int CertificateId)
        {
            DBConnectionHandler.CertificatesGateway.DeleteCertificate(CertificateId);
        }

        /// <summary>
        /// Получить список сертификатов
        /// </summary>
        /// <returns>BindingList объектов класса Certificate для отображения</returns>
        public BindingList<Certificate> GetCertificatesRegistry()
        {
            return new BindingList<Certificate>(DBConnectionHandler.CertificatesGateway.GetCertificatesRegistry());
        }
    }
}
