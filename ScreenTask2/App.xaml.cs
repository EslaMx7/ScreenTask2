using ScreenTask2.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenTask2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            AppManager.Log.Info("Application Started");
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
            
            base.OnStartup(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            AppManager.Log.Info("Application Exited");
             base.OnExit(e);
        }
        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            AppManager.Log.ErrorException(e.Exception.Message, e.Exception);
        }
    }
}
