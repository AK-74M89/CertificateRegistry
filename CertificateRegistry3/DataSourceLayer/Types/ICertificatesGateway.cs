using System;
using System.Collections.Generic;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Описывает управление сертификатами
    /// </summary>
    public interface ICertificatesGateway
    {
        int AddCertificate(string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId);

        void EditCertificate(int CertificateId, string Name, string Number, DateTime BeginDate, DateTime EndDate, int OrganizationId);

        void DeleteCertificate(int CertificateId);

        List<Certificate> GetCertificatesRegistry();
    }
}
