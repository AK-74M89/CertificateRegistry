using System.Collections.Generic;
using SertificateRegistry2.DataSourceLayer;

namespace SertificateRegistry2.DomainLayer
{
    class Organization
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
                OrganizationGateway.AddOrganization(Name);
            }
        }

        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="ID_Organization">идентификатор организации</param>
        public void DeleteOrganization(int ID_Organization)
        {
            OrganizationGateway.DeleteOrganization(ID_Organization);
        }

        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>массив записей OrganizationListItem</returns>
        public IList<OrganizationListItem> GetOrganizationList()
        {
            return OrganizationGateway.GetOrganizationList();
        }       
    }
}
