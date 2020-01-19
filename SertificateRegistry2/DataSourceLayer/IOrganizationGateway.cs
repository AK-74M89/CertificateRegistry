using CertificateRegistry3.DomainLayer;
using System.Collections.Generic;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Описывает управление организациями
    /// </summary>
    public interface IOrganizationGateway
    {
        int AddOrganization(string Name);

        void DeleteOrganization(int OrganizationId);

        List<Organization> GetOrganizationList();
    }
}
