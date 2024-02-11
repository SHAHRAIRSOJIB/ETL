using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.BussinessLayer.Service
{
    public class SqlConnectionString
    {
        public string ProjectCS { get; set; }
        public string ApiKey { get; set; }
        public string GetConnectionString(string ProjectCsKey)
        {
            string CS = "";
            if (ProjectCsKey == "default")
            {
                CS = "Data Source=DESKTOP-96EEJ1H\\SQLEXPRESS;Initial Catalog=ExelTechLtdDb;Trusted_Connection=True";
            }
            return CS;
        }


    }
}
