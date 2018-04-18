using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HostManageTool
{
    public static class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly string keyFile = Environment.SystemDirectory + @"\hostManageTool.key";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string AppName = "HostManageTool";

        /// <summary>
        /// 
        /// </summary>
        public static Config Config = new Config();


        public static readonly string  configPath = Application.StartupPath + "\\config.xml";

        public static string cpuId;
        public static string diskId;
        public static string computerName;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(File.Exists(configPath))
            {
                Config = Bonn.Helper.XmlHelper.XmlDeserializeFromFile<Config>(configPath);
            }
            else
            {
                Bonn.Helper.XmlHelper.XmlSerializeToFile(Config, configPath);
            }

 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
