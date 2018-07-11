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

namespace WpfApp_Class._3._WPF_Controls_UI
{
    /// <summary>
    /// UserControl_MyPage.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl_MyPage : UserControl
    {
        public UserControl_MyPage()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return lable1.Content.ToString();
            }

            set
            {
                this.lable1.Content = value;
                            }
        }
        string _imageURL ;
        public string imageURL
        {
            get
            {
                return _imageURL;
            }

            set
            {
                BitmapImage bi1 = new BitmapImage();
                bi1.BeginInit();
                bi1.UriSource = new Uri(value, UriKind.RelativeOrAbsolute);
                bi1.EndInit();
                this.img1.Source = bi1;
                _imageURL = value;
            }
                
                 }

        byte[] _byte = null;
        public byte[] ImageBytes {
            get
            {
                return _byte;
            }


            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                BitmapImage bi2 = new BitmapImage();
                bi2.BeginInit();
                bi2.StreamSource = ms;
                bi2.EndInit();
                this.img1.Source = bi2;
                _byte = value;


            }
                }

        private void checkbox1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
