using MyAWEntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApplication1._4._WPF_多媒體應用
{
    /// <summary>
    /// Window_DataSourceTool_DataGrid.xaml 的互動邏輯
    /// </summary>
    public partial class Window_DataSourceTool_DataGrid_Starter : Window
    {
        public Window_DataSourceTool_DataGrid_Starter()
        {
            InitializeComponent();
        }
           AdventureWorksEntities db = new AdventureWorksEntities();
        System.Windows.Data.CollectionViewSource productPhotoViewSource;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //List<ProductPhoto> ProductPhotoes = db.ProductPhotoes.ToList();

            //productPhotoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productPhotoViewSource")));
            //// 透過設定 CollectionViewSource.Source 屬性載入資料: 

            //productPhotoViewSource.Source = ProductPhotoes;


            //------------------------
            productPhotoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productPhotoViewSource")));
            // 透過設定 CollectionViewSource.Source 屬性載入資料: 

            //db = new MyAWEntityModel.AdventureWorksEntities();
            db.ProductPhotoes.Load();

            productPhotoViewSource.Source = db.ProductPhotoes.Local;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.productPhotoViewSource.View.MoveCurrentToNext();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //add
            this.db.ProductPhotoes.Local.Add(new ProductPhoto
            {
                ModifiedDate = this.modifiedDateDatePicker.SelectedDate,
                LargePhotoFileName = largePhotoFileNameTextBox.Text,
                ProductPhotoID= int.Parse(productPhotoIDTextBox.Text),

            });

            //this.db.ProductPhotoes.Local.Add(new ProductPhoto
            //{
            //    ModifiedDate = DateTime.Now,
            //    LargePhotoFileName = DateTime.Now.ToLongTimeString()
            //});

            this.productPhotoViewSource.View.MoveCurrentToLast();
           // this.productPhotoViewSource.View.MoveCurrentToNext();

            this.productPhotoDataGrid.ScrollIntoView(this.productPhotoViewSource.View.CurrentItem);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.productPhotoViewSource.View.MoveCurrentToPrevious();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int minyear = int.Parse(txtyear1.Text);
            int maxyear = int.Parse(txtyear2.Text);

            productPhotoViewSource.Source = db.ProductPhotoes.Where(d => d.ModifiedDate.Value.Year>=minyear&&d.ModifiedDate.Value.Year<=maxyear).ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //remove
            int pos = this.productPhotoViewSource.View.CurrentPosition;

            this.db.ProductPhotoes.Local.RemoveAt(pos);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //modify
            int Pos = this.productPhotoViewSource.View.CurrentPosition;
            var prod = (ProductPhoto)this.productPhotoViewSource.View.CurrentItem;

            prod.ModifiedDate = DateTime.Now;
            prod.LargePhotoFileName = DateTime.Now.ToShortTimeString();

            //should Notify propertyChanged to UI 
            this.productPhotoViewSource.View.Refresh();

            this.productPhotoViewSource.View.MoveCurrentToPosition(Pos);
            this.productPhotoDataGrid.ScrollIntoView(this.productPhotoViewSource.View.CurrentItem);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.db.SaveChanges();
        }
    }
}
