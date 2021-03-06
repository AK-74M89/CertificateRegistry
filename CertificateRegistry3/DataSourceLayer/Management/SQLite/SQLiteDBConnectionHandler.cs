﻿using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Управляет подключением к базе данных SQLite
    /// </summary>
    public class SQLiteDBConnectionHandler : IDBConnectionHandler, IDisposable
    {
        private bool disposed = false;

        private SQLiteConnection connection = null;

        private void InitDB()
        {
            using (var Command = new SQLiteCommand(connection))
            {
                Command.CommandText = @"CREATE TABLE IF NOT EXISTS organizations 
                                        (
                                            id   INTEGER       PRIMARY KEY AUTOINCREMENT,
                                            name VARCHAR(255) NOT NULL
                                        )";
                Command.ExecuteNonQuery();

                Command.CommandText = @"CREATE TABLE IF NOT EXISTS certificates 
                                        (
                                            id              INTEGER       PRIMARY KEY AUTOINCREMENT,
                                            name            VARCHAR (255) NOT NULL,
                                            number          VARCHAR (255) NOT NULL,
                                            date_begin      DATE          NOT NULL,
                                            date_end        DATE          NOT NULL,
                                            id_organization INTEGER       NOT NULL REFERENCES organizations (id)
                                        )";
                Command.ExecuteNonQuery();
            }
        }

        public void Connect()
        {
            if (connection == null)
            {
                var ConnectionStringCreator = new SQLiteConnectionStringBuilder
                {
                    DataSource = Path.Combine(Application.StartupPath, "certificates.sqlite"),
                    FailIfMissing = false,
                    JournalMode = SQLiteJournalModeEnum.Wal
                };
                connection = new SQLiteConnection(ConnectionStringCreator.ConnectionString);
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                InitDB();
            }
        }

        public void Disconnect()
        {
            if ((DBConnection != null) && (DBConnection.State != ConnectionState.Closed))
            {
                DBConnection.Close();
            }
        }

        public DbConnection DBConnection
        {
            get
            {
                if (connection == null)
                    Connect();
                return connection;
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
