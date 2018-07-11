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
using System.Windows.Shapes;

namespace WpfApp_Class._4._WPF_多媒體運用
{
    /// <summary>
    /// Window_Resource.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Resource : Window
    {
        public Window_Resource()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["bursh1"] = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
