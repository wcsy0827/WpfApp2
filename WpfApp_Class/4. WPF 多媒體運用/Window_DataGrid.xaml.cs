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
    /// Window_DataGrid.xaml 的互動邏輯
    /// </summary>
    public partial class Window_DataGrid : Window
    {
        public Window_DataGrid()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource productPhotoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productPhotoViewSource")));
            global::MyAWEntityModel.AdventureWorksEntities dbContext = new MyAWEntityModel.AdventureWorksEntities();
            // 透過設定 CollectionViewSource.Source 屬性載入資料: 
            dbContext.ProductPhotoes.ToArray();
            productPhotoViewSource.Source = dbContext.ProductPhotoes.Local;
        }
    }
}
