using CertificateRegistry3.Properties;
using System.IO;
using System.Text;

namespace CertificateRegistry3.DataSourceLayer
{
    class TemplateLoader
    {
        public string LoadTemplate()
        {
            return Resources.registry;
        }
    }
}