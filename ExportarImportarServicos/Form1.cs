using ExportarImportarServicos.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExportarImportarServicos
{
    public partial class ImportExportServices : Form
    {
        public ImportExportServices()
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
            checkedListBoxServices.Items.Clear();   
            string nameService = txtNameService.Text;
            if(nameService == "Digite o nome do serviço" || String.IsNullOrEmpty(nameService))
            {
                MessageBox.Show("Digite um nome de Serviço Válido.");
            }
            else
            {
                List<String> servicesNames =UtilService.ListServicesNames(nameService,cbActive.Checked);
                if(servicesNames != null)
                {
                    foreach(String serviceName in servicesNames)
                    {
                        checkedListBoxServices.Items.Add(serviceName);

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNameService_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtNameService_Selected(object sender, EventArgs e)
        {
            if(txtNameService.Text == "Digite o nome do serviço")
            {
                txtNameService.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPath.Text))
            {
                List<String> checkedNameServices = new List<String>();
                foreach (string serviceName in checkedListBoxServices.CheckedItems)
                {
                    checkedNameServices.Add(serviceName);
                }
                var services = UtilService.ListServicesNamesChecked(checkedNameServices);
                UtilService.ExportServices(services, txtPath.Text);
            }
            else
            {
                MessageBox.Show("O caminho não pode estar vazio.");
            }
            
           



        }
    }
}
