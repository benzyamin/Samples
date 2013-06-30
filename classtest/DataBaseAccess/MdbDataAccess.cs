using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace KK.Common
{
    class MdbDataAccess : DataBaseAccess
    {
        public MdbDataAccess()
            : base()
        {
        }





        protected override void InitConnectObject()
        {
            Connection = new OleDbConnection(createConnectionString());
            Adapter = new OleDbDataAdapter(new OleDbCommand("", Connection as OleDbConnection));
            
        }

        private string createConnectionString()
        {
            return createConnectionString2007();
        }
        private string createConnectionString2007()
        {
            return Environment.ConnectionInfo.GetConnectionString();
        }
    }
}
