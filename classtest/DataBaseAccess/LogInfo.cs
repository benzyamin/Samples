using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KK.Common
{
    public class LogInfo
    {
        public LogInfo()
        {
            this.load();
        }
        public string OutputPath { get;private set; }
        public string FileName { get; private set; }
        private void load()
        {
            OutputPath = "C:\\Log";
            FileName = "log.log";
        }
    }
}
