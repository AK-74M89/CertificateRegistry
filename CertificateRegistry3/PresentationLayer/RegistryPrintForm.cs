using System;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class RegistryPrintForm:Form
    {
        public RegistryPrintForm(string certificatesTable, string caption = "")
        {
            InitializeComponent();

            Text = string.IsNullOrEmpty(caption) ? Text : caption;
            RegistryPreview.DocumentText = certificatesTable;
            DialogResult = DialogResult.OK;
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
