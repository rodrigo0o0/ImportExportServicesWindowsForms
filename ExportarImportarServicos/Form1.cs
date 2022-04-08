using System;
using System.Windows.Forms;

namespace ExportarImportarServicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            txtPath.Text = path;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nameService = txtNameService.Text;
            if(nameService == "Digite o nome do serviço" || String.IsNullOrEmpty(nameService))
            {
                MessageBox.Show("Preencha o campo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
