using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_Class._3._WPF_Controls_UI;
using WpfApp_Class._4._WPF_多媒體運用;
using WpfApp_Class.XMAL_Language;
using WpfApplication1._4._WPF_多媒體應用;

namespace WpfApp_Class
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
         {
        this.ShutdownMode = ShutdownMode.OnLastWindowClose;
        Window w = new Window_DataSourceTool_DataGrid_Starter();

            w.Show();
    }


    }

    //    public App()
    //    {
    //        this.Startup += App_Startup;
    //    }

    //    private void App_Startup(object sender, StartupEventArgs e)
    //    {
    //        this.ShutdownMode = ShutdownMode.OnLastWindowClose;
    //        Window w = new MainWindow();
    //        w.Show();
    //    }



}
