using System.Collections.Generic;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Описывает управление организациями
    /// </summary>
    public interface IOrganizationGateway
    {
        int AddOrganization(string Name);

        void EditOrganization(int OrganizationId, string Name);

        bool CanDelete(int OrganizationId);

        void DeleteOrganization(int OrganizationId);

        List<Organization> GetOrganizationList();
    }
}
