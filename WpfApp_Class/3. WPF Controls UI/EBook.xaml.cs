using MyAWEntityModel;
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

namespace WpfApp_Class._3._WPF_Controls_UI
{
    /// <summary>
    /// EBook.xaml 的互動邏輯
    /// </summary>
    public partial class EBook : Window
    {
        public EBook()
        {
            InitializeComponent();
            UserControl_MyPage page1= new UserControl_MyPage();


            

        }
        //要先判斷圖檔是URL還是從DB抓的
        //判斷X的來源
        private void Checkbox1_Checked(object sender, RoutedEventArgs e)
        {
            this.panel3.Children.Clear();
            foreach (UserControl_MyPage x in book1.Items)
            {


                if (x.checkbox1.IsChecked==true&& x.imageURL != null)
                {
                    UserControl_MyPage y = new UserControl_MyPage();
                    y.Height =100;
                    y.Width = 100;
                    y.Title = x.Title;
                    y.imageURL = x.imageURL;
                    this.panel3.Children.Add(y);

                }
                else if(x.checkbox1.IsChecked == true && x.ImageBytes != null)
                {
                    UserControl_MyPage y = new UserControl_MyPage();
                    y.Height = 100;
                    y.Width = 100;
                    y.Title = x.Title;
                    y.ImageBytes = x.ImageBytes;
                    this.panel3.Children.Add(y);

                }

            }
        }
        private void Checkbox1_Unchecked(object sender, RoutedEventArgs e)
        {
            this.panel3.Children.Clear();
            foreach (UserControl_MyPage x in book1.Items)
            {


                if (x.checkbox1.IsChecked == true && x.imageURL != null)
                {
                    UserControl_MyPage y = new UserControl_MyPage();
                    y.Height = 100;
                    y.Width = 100;
                    y.Title = x.Title;
                    y.imageURL = x.imageURL;
                    this.panel3.Children.Add(y);

                }
                else if (x.checkbox1.IsChecked == true && x.ImageBytes!= null)
                {
                    UserControl_MyPage y = new UserControl_MyPage();
                    y.Height = 100;
                    y.Width = 100;
                    y.Title = x.Title;
                    y.ImageBytes = x.ImageBytes;
                    this.panel3.Children.Add(y);

                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.book1.CurrentSheetIndex = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.book1.AnimateToPreviousPage(true, 500);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.book1.AnimateToNextPage(true, 500);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.book1.CurrentSheetIndex = book1.Items.Count/2;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var PhotoList = global::PhotoDataModel_V2.PhotoDataSource.Search("FIFAWORLDCUP");

            for(int i=0; i<PhotoList.Count;i++)
            {
                UserControl_MyPage page = new UserControl_MyPage();

                page.checkbox1.Checked += Checkbox1_Checked;
                page.checkbox1.Unchecked += Checkbox1_Unchecked;
                page.Title = PhotoList[i].Title;
                page.imageURL = PhotoList[i].ImagePath;
                this.book1.Items.Add(page);


            }
        }



        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AdventureWorksEntities dbContext = new AdventureWorksEntities();
            var query = from p in dbContext.ProductPhotoes
                        select p;
            List<ProductPhoto> ProductList = query.ToList();
            for(int i=0;i<ProductList.Count;i++)
            {
                UserControl_MyPage mypage = new UserControl_MyPage();
                mypage.checkbox1.Checked += Checkbox1_Checked;
                mypage.checkbox1.Unchecked += Checkbox1_Unchecked;
                mypage.Title = ProductList[i].ModifiedDate.Value.ToShortDateString();
                mypage.ImageBytes = ProductList[i].LargePhoto;
                this.book1.Items.Add(mypage);
            }

        }
        
        
        
        
    }
}
