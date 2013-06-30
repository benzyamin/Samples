using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KK.Common
{
    class SqlDataAccess : DataBaseAccess
    {
        public SqlDataAccess()
            : base()
        {
        }





        protected override void InitConnectObject()
        {
            Connection = new SqlConnection(createConnectionString());
            Adapter = new SqlDataAdapter(new SqlCommand("", Connection as SqlConnection));
            
        }

        private string createConnectionString()
        {
            return Environment.ConnectionInfo.GetConnectionString();
        }
    }
}
