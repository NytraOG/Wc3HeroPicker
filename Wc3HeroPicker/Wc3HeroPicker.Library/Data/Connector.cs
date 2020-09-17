using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Wc3HeroPicker.Library.Data
{
    public class Connector
    {
        private readonly string connectionString;

        public Connector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public 
    }
}
