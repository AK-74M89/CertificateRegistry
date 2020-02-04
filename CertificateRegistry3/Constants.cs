using System.Collections.Generic;

namespace CertificateRegistry3
{
    public class Constants
    {
        public const string DB_TYPE_POSTGRESQL = "PostgreSQL";
        public const string DB_TYPE_SQLITE = "SQLite";
        public static readonly List<string> DBTypes = new List<string>() { DB_TYPE_POSTGRESQL, DB_TYPE_SQLITE };
    }
}
