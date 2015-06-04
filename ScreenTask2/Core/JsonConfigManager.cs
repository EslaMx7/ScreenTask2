using Newtonsoft.Json;
using ScreenTask2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTask2.Core
{
    public class JsonConfigManager : IAppConfigManager
    {
        public bool Save()
        {
            try
            {
                var config = JsonConvert.SerializeObject(AppManager.Configurations, Formatting.Indented);
                File.WriteAllText(Path.Combine(AppManager.CurrentDirectory, "config.json"), config, Encoding.UTF8);
                AppManager.Log.Info("Config Saved");
                return true;
            }
            catch (Exception ex)
            {
                AppManager.Log.ErrorException("Config Saving Error",ex);
                return false;
            }
        }


        public bool Load()
        {
            try
            {
                var config = File.ReadAllText(Path.Combine(AppManager.CurrentDirectory,"config.json"));
                AppManager.Configurations = JsonConvert.DeserializeObject<AppConfig>(config);
                AppManager.Log.Info("Config Loaded");
                return true;
            }
            catch (Exception ex)
            {
                AppManager.Log.ErrorException("Config Loading Error",ex);
                return false;
            }
        }


        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
