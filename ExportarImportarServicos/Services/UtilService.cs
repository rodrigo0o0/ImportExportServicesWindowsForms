using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace ExportarImportarServicos.Services
{
    static class UtilService
    {
        public static ManagementObjectCollection GetAllServices()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Service ");
            ManagementObjectCollection services = searcher.Get();
            return services;
        }
        //Rertorna a lista com checked
        public static List<ManagementBaseObject> ListServicesNamesChecked(List<String> names)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Service ");
            ManagementObjectCollection services = searcher.Get();
            List<ManagementBaseObject> selectedServices = new List<ManagementBaseObject>();
            foreach (ManagementBaseObject service in services)
            {
                string displayName = service["DisplayName"] as string;
                foreach (var name in names)
                {
                    if (name.ToLower() == displayName.ToLower())
                    {
                        selectedServices.Add(service);
                    }
                }

            }
            return selectedServices;
        }


        public static List<String> ListServicesNames(string nameSearch, bool active)
        {
            nameSearch = nameSearch.ToLower();
            List<String> listServicesNames = new List<String>();
            var services = GetAllServices();
            foreach (ManagementBaseObject service in services)
            {
                string displayName = service["DisplayName"] as string;
                string startMode = service["StartMode"] as string;


                if (active)
                {
                    if (displayName.ToLower().Contains(nameSearch) && (startMode == "Auto" || startMode == "Manual"))
                    {
                        listServicesNames.Add(displayName);
                    }
                }
                else if (displayName.ToLower().Contains(nameSearch))
                {
                    listServicesNames.Add(displayName);
                }

            }
            return listServicesNames;
        }

        public static void ExportServices(List<ManagementBaseObject> services, string filePath)
        {
            // Check if file already exists. If yes, delete it.     
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            filePath += @"\services.txt";

            using (StreamWriter sw = File.CreateText(filePath))
            {
                foreach (var service in services)
                {
                    string name = service["Name"] as string;
                    string displayName = service["DisplayName"] as string;
                    MessageBox.Show(name + " " + displayName);
                    string pathName = service["PathName"] as string;
                    string startMode = service["StartMode"] as string;

                    string line = "sc create ";
                    line += name;
                    line += " binPath= ";
                    line += pathName.Split(' ')[0];

                    line += " DisplayName= " + displayName;
                    line += " Start= Disabled";
                    line = line.Replace("\"", "");

                    sw.WriteLine(line);

                }

                MessageBox.Show("Script de criação do(s) serviços criado no caminho : " + filePath);
            }
        }
    }
}
