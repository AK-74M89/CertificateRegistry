using CertificateRegistry3.DataSourceLayer;
using System.Collections.Generic;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Бизнес-логика работы с организациями
    /// </summary>
    public class OrganizationManager
    {
        /// <summary>
        /// Добавить организацию
        /// </summary>
        /// <param name="Name">название организации</param>
        public void AddOrganization(string Name)
        {
            if (!Checker.CheckRegularString(Name))
            {
                throw (new DomainException("Длина имени должна быть менее 255 символов"));
            }
            else
            {
                DBConnectionHandler.OrganizationGateway.AddOrganization(Name);
            }
        }

        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="OrganizationId">идентификатор организации</param>
        public void DeleteOrganization(int OrganizationId)
        {
            DBConnectionHandler.OrganizationGateway.DeleteOrganization(OrganizationId);
        }

        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>Список объектов класса Organization</returns>
        public List<Organization> GetOrganizationList()
        {
            return DBConnectionHandler.OrganizationGateway.GetOrganizationList();
        }       
    }
}
