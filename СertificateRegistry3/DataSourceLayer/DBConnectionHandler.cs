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
                    switch (Settings.Default.DBType)
                    {
                        case "PostgreSQL":
                        {
                            connectionHandler = new PostgreSQLDBConnectionHandler();
                            break;
                        }
                        case "SQLite":
                        {
                            connectionHandler = new SQLiteDBConnectionHandler();
                            break;
                        }
                        default:
                        {
                            throw new NotImplementedException($"Подключение к {Settings.Default.DBType} не реализовано");
                        }
                    }
                }
                return connectionHandler;
            }
        }

        public static ICertificatesGateway CertificatesGateway
        {
            get
            {
                if (certificatesGateway == null)
                {
                    switch (Settings.Default.DBType)
                    {
                        case "PostgreSQL":
                        {
                                certificatesGateway = new PostgreSQLCertificateGateway(ConnectionHandler.DBConnection);
                                break;
                        }
                        case "SQLite":
                        {
                            certificatesGateway = new SQLiteCertificateGateway(ConnectionHandler.DBConnection);
                            break;
                        }
                        default:
                        {
                            throw new NotImplementedException($"Подключение к {Settings.Default.DBType} не реализовано");
                        }
                    }
                }
                
                return certificatesGateway;
            }
        }
    
        public static IOrganizationGateway OrganizationGateway
        {
            get
            {
                if (organizationGateway == null)
                {
                    switch (Settings.Default.DBType)
                    {
                        case "PostgreSQL":
                        {
                            organizationGateway = new PostgreSQLOrganizationGateway(ConnectionHandler.DBConnection);
                            break;
                        }
                        case "SQLite":
                        {
                            organizationGateway = new SQLiteOrganizationGateway(ConnectionHandler.DBConnection);
                            break;
                        }
                        default:
                        {
                            throw new NotImplementedException($"Подключение к {Settings.Default.DBType} не реализовано");
                        }
                    }
                }
                return organizationGateway;
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
