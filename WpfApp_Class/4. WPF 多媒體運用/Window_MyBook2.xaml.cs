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
    /// Window_MyBook2.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyBook2 : Window
    {
        public Window_MyBook2()
        {
            InitializeComponent();
            var PhotoList = global::PhotoDataModel_V2.PhotoDataSource.Search("FIFAWORLDCUP");
            book2.ItemsSource = PhotoList;
        }
    }
}
