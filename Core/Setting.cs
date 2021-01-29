using System;
using XS.Core;

namespace ProxyIpTools.Core
{
    public class Setting
    {
        public static readonly Setting Instance = new Setting();


        private IniParser iniParser;

        private Setting()
        {
            //D:\\web\\BeiMaiProject\\beimai5.0\\Web\\BeiMai.WebApp\\BeiMai.WebApp\\bin
            string sPath = AppDomain.CurrentDomain.BaseDirectory;
#if DEBUG
            if (sPath.EndsWith("\\bin"))
                sPath = sPath.Replace("\\bin", "");
#endif
            iniParser = new IniParser(string.Concat(sPath, @"\conf\conf.ini"));
            
            //app
            TimeOut = int.Parse(iniParser.GetSetting("App", "TimeOut"));
            Conn = iniParser.GetSetting("App", "Conn");


        }

        public void Save()
        {
            //app
            iniParser.AddSetting("App", "Conn", Conn);
            iniParser.AddSetting("App", "TimeOut", TimeOut.ToString());

            iniParser.SaveSettings();

        }


        //app
        public int TimeOut { get; set; }
        public string Conn { get; set; }


    }
}