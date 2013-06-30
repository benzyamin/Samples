using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KK.Common
{
    static class Environment
    {
         static Environment()
        {
            load();
        }

        static DbType dbtype = DbType.SqlServer;
        static LogInfo LogInfo { get; set; }
        public static ConnectionInfo ConnectionInfo { get;private set; }
        private static void load()
        {
            ConnectionInfo = ConnectionInfo.CreateInstance(dbtype);
            ConnectionInfo.LoadDbInfo();

            LogInfo = new LogInfo();

        }    
    }
}
