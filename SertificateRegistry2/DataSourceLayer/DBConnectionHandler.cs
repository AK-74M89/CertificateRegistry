using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SertificateRegistry2.DataSourceLayer
{
    static class DBConnectionHandler
    {
        private static SQLiteConnection DBConnection = null;

        private static void InitDB()
        {
            new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS organizations 
                                (
                                    id   INTEGER       PRIMARY KEY AUTOINCREMENT,
                                    name VARCHAR(255) NOT NULL
                                )", DBConnection).ExecuteNonQuery();


            new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS certificates 
                                (
                                    id              INTEGER       PRIMARY KEY AUTOINCREMENT,
                                    name            VARCHAR (255) NOT NULL,
                                    number          VARCHAR (255) NOT NULL,
                                    date_begin      DATE          NOT NULL,
                                    date_end        DATE          NOT NULL,
                                    id_organization INTEGER       NOT NULL REFERENCES organizations (id)
                                )", DBConnection).ExecuteNonQuery();
        }

        public static void Connect()
        {
            if (DBConnection == null)
            {
                SQLiteConnectionStringBuilder ConnectionStringCreator = new SQLiteConnectionStringBuilder();
                ConnectionStringCreator.DataSource = Path.Combine(Application.StartupPath, "certificates.sqlite");
                ConnectionStringCreator.FailIfMissing = false;
                ConnectionStringCreator.JournalMode = SQLiteJournalModeEnum.Wal;                
                string ConnectionString = ConnectionStringCreator.ConnectionString;
                DBConnection = new SQLiteConnection(ConnectionString);
            }
            if (DBConnection.State != ConnectionState.Open)
            {
                DBConnection.Open();
                InitDB();
            }
        }

        public static void Disconnect()
        {
            if ((DBConnection != null) && (DBConnection.State != ConnectionState.Closed))
            {
                DBConnection.Close();
            }
        }

        public static SQLiteConnection Connection
        {
            get
            {
                if (DBConnection == null)
                    Connect();
                return DBConnection;
            }
        }
    }
}
