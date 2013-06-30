using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace KK.Common
{
    public class ErrorHandler
    {
        public static void Execute(Action action,IWin32Window window)
        {
            try
            {
                action();
            }
            catch(Exception ex)
            {
                MessageBox.Show(window,ex.Message);
            }
        }
        public static void Execute(Action action)
        {
            try
            {
                action();
            }
            catch(Exception ex)
            {
                LogManger.WriteErrorLog(ex);
            }
        }
        
    }

    enum ErrorType
    {
        BusinessError,
        SystemError

    }
}
