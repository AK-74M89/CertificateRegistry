using System.Data.Common;

namespace CertificateRegistry3.DataSourceLayer
{
    /// <summary>
    /// Интерфейс управления подключением к базе данных
    /// </summary>
    public interface IDBConnectionHandler
    {
        DbConnection DBConnection { get; }

        void Connect();

        void Disconnect();
    }
}
