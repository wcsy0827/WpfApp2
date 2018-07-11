using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_Class._3._WPF_Controls_UI;
using WpfApp_Class.XMAL_Language;
using WpfApplication1._4._WPF_多媒體應用;

namespace WPF_HW
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EBook w = new EBook();
                w.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window_MyNotepad w = new Window_MyNotepad();
            w.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window_DataSourceTool_DataGrid_Starter w = new Window_DataSourceTool_DataGrid_Starter();
            w.Show();

        }
    }
}
