using System.IO;
using System.Text;

namespace SertificateRegistry2.DataSourceLayer
{
    class TemplateLoader
    {
        private string template_path;
            
        public TemplateLoader(string FilePath = "Templates\\registry.html")
        {
            template_path = FilePath;
        }

        public string LoadTemplate()
        {
            if (!File.Exists(template_path))
            {
                throw (new FileNotFoundException($"Файл шаблона \"{template_path}\" не найден"));
            }
            return File.ReadAllText(template_path, Encoding.UTF8);
        }
    }
}