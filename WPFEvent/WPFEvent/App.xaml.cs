using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows;

namespace WPFEvent
{
    
    public partial class App : Application
    {


        protected void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mWindow = new MainWindow();

            if (e.Args.Count() == 1) { MessageBox.Show("Now Opening File /n/n" + e.Args[0]); }

            mWindow.Show();
        }
    }
}
