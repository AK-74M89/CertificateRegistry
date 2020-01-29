using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.Properties;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Управление шаблонами для печати
    /// </summary>
    class TemplateManager
    {
        private TemplateLoader loader;

        public TemplateManager()
        {
            loader = new TemplateLoader();
        }

        public string FillTemplate(List<Certificate> CertificateList)
        {
            XDocument dataFile = new XDocument(
                                        new XDeclaration("1.0", "UTF-8", "yes"),
                                        new XElement("registry",
                                            new XElement("certificates",
                                                CertificateList.Select(c => new XElement("certificate",
                                                                                    new XElement("name", c.CertificateName),
                                                                                    new XElement("number", c.Number),
                                                                                    new XElement("begin_date", c.BeginDate.ToShortDateString()),
                                                                                    new XElement("end_date", c.EndDate.ToShortDateString()),
                                                                                    new XElement("organization", c.Organization)
                                                                                )
                                                )
                                            ),
                                            new XElement("address", Settings.Default.PrintAddress)
                                        )
                                    );

            var transformedDoc = new XDocument();
            using (XmlWriter writer = transformedDoc.CreateWriter())
            {
                var transform = new XslCompiledTransform();
                transform.Load(XmlReader.Create(new StringReader(loader.LoadTemplate())));
                transform.Transform(dataFile.CreateReader(), writer);
            }

            return transformedDoc.ToString();
        }
    }
}