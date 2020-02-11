using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.PresentationLayer;
using System;
using System.Windows.Forms;

namespace CertificateRegistry3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConnectionHandler.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CertificatesListForm());
            DBConnectionHandler.Disconnect();
        }
    }
}