using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFEvent
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
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
