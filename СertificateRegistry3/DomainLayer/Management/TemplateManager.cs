using CertificateRegistry3.DataSourceLayer;
using System;
using System.Collections.Generic;

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
            string Template = loader.LoadTemplate();
            string[] TemplatePartsSeparator = new string[1];
            TemplatePartsSeparator[0] = "<!-- -->";
            string[] TemplateParts = Template.Split(TemplatePartsSeparator, StringSplitOptions.None); 
            string FilledTemplate = TemplateParts[0];
            for (int i = 0; i < CertificateList.Count; i++)
            {
                string CurrentTableRow = TemplateParts[1].Replace("#Name#", CertificateList[i].CertificateName);
                CurrentTableRow = CurrentTableRow.Replace("#Number#", CertificateList[i].Number);
                CurrentTableRow = CurrentTableRow.Replace("#BeginDate#", CertificateList[i].BeginDate.ToShortDateString());
                CurrentTableRow = CurrentTableRow.Replace("#EndDate#", CertificateList[i].EndDate.ToShortDateString());
                CurrentTableRow = CurrentTableRow.Replace("#Organization#", CertificateList[i].Organization);
                FilledTemplate += CurrentTableRow;
            }
            FilledTemplate += TemplateParts[2];

            return FilledTemplate;
        }
    }
}