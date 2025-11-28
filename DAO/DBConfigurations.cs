using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DBConfigurations
    {
        public static string getDbConectionString()
        {
            return ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        }
    }
}
