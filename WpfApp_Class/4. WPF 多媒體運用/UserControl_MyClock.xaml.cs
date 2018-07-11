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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Class._4._WPF_多媒體運用
{
    /// <summary>
    /// UserControl_MyClock.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl_MyClock :Window
    {
        public UserControl_MyClock()
        {
            InitializeComponent();

            //((Storyboard)grid1.Resources["sb1"]).Begin(this, true);
            //((Storyboard)grid1.Resources["sb1"]).Seek(this, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime);
        }
    }
}
