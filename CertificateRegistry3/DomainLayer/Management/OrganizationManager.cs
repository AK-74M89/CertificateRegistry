using CertificateRegistry3.DataSourceLayer;
using System.Collections.Generic;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Бизнес-логика работы с организациями
    /// </summary>
    public static class OrganizationManager
    {
        /// <summary>
        /// Добавить организацию
        /// </summary>
        /// <param name="Name">Название организации</param>
        public static void AddOrganization(string Name)
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
        /// Изменить организацию
        /// </summary>
        /// <param name="OrganizationId">Название организации</param>
        /// <param name="Name">Идентификатор организации</param>
        public static void EditOrganization(int OrganizationId, string Name)
        {
            if (!Checker.CheckRegularString(Name))
            {
                throw (new DomainException("Длина имени должна быть менее 255 символов"));
            }
            else
            {
                DBConnectionHandler.OrganizationGateway.EditOrganization(OrganizationId, Name);
            }
        }

        /// <summary>
        /// Удалять можно только организации, к которым не привязаны сертификаты
        /// </summary>
        /// <param name="OrganizationId">Идентификатор организации</param>
        /// <returns></returns>
        public static bool CanDelete(int OrganizationId)
        {
            return DBConnectionHandler.OrganizationGateway.CanDelete(OrganizationId);
        }

        /// <summary>
        /// Удалить организацию
        /// </summary>
        /// <param name="OrganizationId">Идентификатор организации</param>
        public static void DeleteOrganization(int OrganizationId)
        {
            DBConnectionHandler.OrganizationGateway.DeleteOrganization(OrganizationId);
        }

        /// <summary>
        /// Получить список организаций
        /// </summary>
        /// <returns>Список объектов класса Organization</returns>
        public static List<Organization> GetOrganizationList()
        {
            return DBConnectionHandler.OrganizationGateway.GetOrganizationList();
        }       
    }
}
