using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;

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


        public static List<String> ListServicesNames(string nameSearch,bool active)
        {
            List<String> listServicesNames = new List<String>();
            var services = GetAllServices();
            foreach (ManagementBaseObject service in services)
            {
                string displayName = service["DisplayName"] as string;
                string startMode = service["StartMode"] as string;

                if (active)
                {
                    if (displayName.ToLower().Contains(nameSearch) && startMode == "Enabled")
                    {
                        listServicesNames.Add(displayName);
                    }
                }else if (displayName.ToLower().Contains(nameSearch))
                {
                    listServicesNames.Add(displayName);
                }

            }
            return listServicesNames;
        }
    }
}
