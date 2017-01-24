using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFApplicationDemo.ICustomCommand;

namespace WPFApplicationDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationOnStartup(object sender, StartupEventArgs e)
        {
            //TestOne t1 = new TestOne();
            //t1.Show();
            //Window1 w = new Window1();
            //w.Show();
            //Dependency_Property.Dependency_Property dp = new Dependency_Property.Dependency_Property();
            //dp.Show();
            //StyleStudy.StyleWindow sw = new StyleStudy.StyleWindow();
            //sw.Show();
            StyleStudy.StyleWindowTwo swt = new StyleStudy.StyleWindowTwo();
            swt.Show();
        }
    }
}
