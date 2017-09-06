using System;
using System.Windows.Forms;

namespace SertificateRegistry2.PresentationLayer
{
    public partial class RegistryPrintForm:Form
    {
        public RegistryPrintForm(string CertificatesTable)
        {
            InitializeComponent();
            
            RegistryPreview.DocumentText = CertificatesTable;
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistryPreview.ShowPrintDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryPreview.ShowPrintPreviewDialog();
        }      
    }
}
