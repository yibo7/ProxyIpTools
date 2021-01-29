using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyIpTools.Core
{
    public class Log
    {
        static public void Error(string loginfo)
        {
            XS.Core.Log.ErrorLog.Error(loginfo);
        }
        static public void Info(string loginfo)
        {
            XS.Core.Log.ErrorLog.Info(loginfo);
        }
    }
}
