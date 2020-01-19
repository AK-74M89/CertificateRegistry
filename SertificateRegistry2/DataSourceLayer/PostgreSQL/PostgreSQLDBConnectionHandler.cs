using CertificateRegistry3.Properties;
using Npgsql;
using System;
using System.Data;
using System.Data.Common;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Управляет подключением к базе данных PostgreSQL
    /// </summary>
    public class PostgreSQLDBConnectionHandler : IDBConnectionHandler, IDisposable
    {
        private bool disposed = false;

        private NpgsqlConnection connection;

        public DbConnection DBConnection
        { 
            get
            {
                return connection;
            }
        }

        public void Connect()
        {
            if (connection == null)
            {
                var ConnectionStringCreator = new NpgsqlConnectionStringBuilder();
                ConnectionStringCreator.Host = Settings.Default.DBServer;
                ConnectionStringCreator.Port = 5432;
                ConnectionStringCreator.Username = Settings.Default.Username;
                ConnectionStringCreator.Password = Settings.Default.Password;
                ConnectionStringCreator.Database = "certificates";
                string ConnectionString = ConnectionStringCreator.ConnectionString;
                connection = new NpgsqlConnection(ConnectionString);
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Disconnect()
        {
            if ((connection != null) && (connection.State != ConnectionState.Closed))
            {
                connection.Close();
            }
        }
    
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    connection.Dispose();
                }

                // Note disposing has been done.
                disposed = true;
            }
        }
    }
}
