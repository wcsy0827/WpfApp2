
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication1.Common;
using WpfApplication1.Other_Test;

namespace WPF_Others_Demo
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Window w;
              w = new Window_Validation(); w.Show();
            w = new Window_ColorConverter(); w.Show();
            w = new Window_Converter(); w.Show();
         

        }
    }
}
