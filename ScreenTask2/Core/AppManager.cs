using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenTask2.Models;
using NLog;

namespace ScreenTask2.Core
{
    public static class AppManager
    {
        static AppManager()
        {
            Configurations = new AppConfig
            {
                AutoStart = false,
                Port = 7070
            };

        }

        public static AppConfig Configurations { get; set; }
        public static string CurrentDirectory { get { return AppDomain.CurrentDomain.BaseDirectory; } }
        public static Logger Log { get { return LogManager.GetCurrentClassLogger(); } }
    }
}
