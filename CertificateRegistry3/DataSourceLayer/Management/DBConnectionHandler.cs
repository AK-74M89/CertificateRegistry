using CertificateRegistry3.Properties;
using System;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Подключение и работа с конкретной базой данных, в зависимости от настроек
    /// </summary>
    public static class DBConnectionHandler
    {
        private static IDBConnectionHandler connectionHandler;
        private static ICertificatesGateway certificatesGateway;
        private static IOrganizationGateway organizationGateway;

        public static IDBConnectionHandler ConnectionHandler
        {
            get
            {
                if (connectionHandler == null)
                {
                    connectionHandler = InitConnectionHandler();
                }
                return connectionHandler;
            }
        }

        private static IDBConnectionHandler InitConnectionHandler()
        {
            switch (Settings.Default.DBType)
            {
                case Constants.DB_TYPE_POSTGRESQL:
                {
                    return new PostgreSQLDBConnectionHandler();
                }
                case Constants.DB_TYPE_SQLITE:
                {
                    return new SQLiteDBConnectionHandler();
                }
                default:
                {
                    throw new NotImplementedException($"Подключение к {Settings.Default.DBType} не реализовано");
                }
            }
        }

        public static ICertificatesGateway CertificatesGateway
        {
            get
            {
                if (certificatesGateway == null)
                {
                    certificatesGateway = InitCertificatesGateway();
                }
                
                return certificatesGateway;
            }
        }

        private static ICertificatesGateway InitCertificatesGateway()
        {
            switch (Settings.Default.DBType)
            {
                case Constants.DB_TYPE_POSTGRESQL:
                {
                    return new PostgreSQLCertificateGateway(ConnectionHandler.DBConnection);
                }
                case Constants.DB_TYPE_SQLITE:
                {
                    return new SQLiteCertificateGateway(ConnectionHandler.DBConnection);
                }
                default:
                {
                    throw new NotImplementedException($"Подключение к {Settings.Default.DBType} не реализовано");
                }
            }
        }

        public static IOrganizationGateway OrganizationGateway
        {
            get
            {
                if (organizationGateway == null)
                {
                    organizationGateway = InitOrganizationGateway();
                }
                return organizationGateway;
            }
        }

        private static IOrganizationGateway InitOrganizationGateway()
        {
            switch (Settings.Default.DBType)
            {
                case Constants.DB_TYPE_POSTGRESQL:
                {
                    return new PostgreSQLOrganizationGateway(ConnectionHandler.DBConnection);
                }
                case Constants.DB_TYPE_SQLITE:
                {
                    return new SQLiteOrganizationGateway(ConnectionHandler.DBConnection);
                }
                default:
                {
                    throw new NotImplementedException($"Подключение к {Settings.Default.DBType} не реализовано");
                }
            }
        }

        public static void Connect()
        {
            ConnectionHandler.Connect();
        }
    
        public static void Disconnect()
        {
            ConnectionHandler.Disconnect();
        }
    }
}
