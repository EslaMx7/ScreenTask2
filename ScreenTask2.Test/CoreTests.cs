using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenTask2.Core;

namespace ScreenTask2.Test
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void TestSavingConfig()
        {
            JsonConfigManager jsConfig = new JsonConfigManager();

            Assert.IsTrue(jsConfig.Save());
            
        }

        [TestMethod]
        public void TestLoadingConfig()
        {
            JsonConfigManager jsConfig = new JsonConfigManager();

            Assert.IsTrue(jsConfig.Load());

        }


        [TestMethod]
        public void TestLoadingChangingSavingConfig()
        {
            JsonConfigManager jsConfig = new JsonConfigManager();

            jsConfig.Load();

            AppManager.Configurations.Port = 1234;
            
            jsConfig.Save();

            jsConfig.Load();

            Assert.AreEqual(AppManager.Configurations.Port, 1234);

        }
    }
}
