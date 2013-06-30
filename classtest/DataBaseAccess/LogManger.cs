using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KK.Common
{
    public static class LogManger
    {
        private static string outputFilePath = "logtest.log"; 
         static LogManger()
        {

        }
        public static void WriteErrorLog(Exception ex)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFilePath, true))
            {
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.StackTrace);

            }
   
        }
        public static void WriteLog(string message)
        {

        }

    }

    
}
