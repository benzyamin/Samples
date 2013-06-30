using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KK.Common
{
    public abstract class ConnectionInfo
    {
        public abstract string GetConnectionString();

        public abstract void LoadDbInfo();
        public static ConnectionInfo CreateInstance(DbType dbtype)
        {
            switch (dbtype)
            {
                case DbType.Mdb:
                    return new MdbConnectionInfo();
                case DbType.SqlServer:
                    return new SqlConnectionInfo();
                default:
                    throw new Exception("aa");
            }
        }
    }

    public class SqlConnectionInfo : ConnectionInfo
    {
        private string user = string.Empty;
        private string passward = string.Empty;
        private string dataSource = string.Empty;
        private string initialCatalog = string.Empty;

        public override string GetConnectionString()
        {
            return string.Format("Persist Security Info=False;Data Source={0};Initial Catalog={1};User ID={2};Password={3}"
                , dataSource, initialCatalog, user, passward);
        }

        public override void LoadDbInfo()
        {
            user = "TestUser";
            passward = "test00";
            dataSource = "TEST-PC\\SQLEXPRESS";
            initialCatalog = "Test";
        }
    }

    public class MdbConnectionInfo : ConnectionInfo
    {
        private const string FORMAT = "Provider={0};Data Source={1}";
        private string provider = string.Empty;
        private string dataSource = string.Empty;

        public override string GetConnectionString()
        {
            return string.Format(FORMAT, provider, dataSource);
        }

        public override void LoadDbInfo()
        {
            provider = "Microsoft.ACE.12.0";
            dataSource = "sample.accdb";

        }
    }
}
