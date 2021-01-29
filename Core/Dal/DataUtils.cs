using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text; 
using Microsoft.Data.Sqlite; 

namespace ProxyIpTools.Core.Dal
{
    public class DataUtils
    {
        //要将sqlite3.dll,Microsoft.Data.Sqlite.dll复制到当前项目的bin下 
        static public IDbConnection GetOpenConnection()
        {
            string sPath = AppDomain.CurrentDomain.BaseDirectory;
#if DEBUG
            if (sPath.EndsWith("\\bin"))
                sPath = sPath.Replace("\\bin", "");
#endif
            string conn = string.Format("Data Source={0};", string.Concat(sPath, "\\data.db"));
            var connection = new SqliteConnection(conn);
            connection.Open();
            return connection;
        }
    }
}
