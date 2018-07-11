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
    /// Window_Binding.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Binding : Window
    {
        public Window_Binding()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Binding binding1 = new Binding();
            binding1.Source = slider2;
            binding1.Path = new PropertyPath("Value");
            img2.SetBinding(WidthProperty, binding1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Class_Employee emp = new Class_Employee
            {
                EmpName = "aaa",
                HireDate = DateTime.Now,
                EmpImage = @"D:\WPFPractice2\WPFPractice2\WpfApp2\WpfApp_Class\PokemonGo\pic_001.png"
                
            };
            stackpanel1.DataContext = emp;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Class_Employee> empList = new List<Class_Employee>();
            empList.Add(new Class_Employee { EmpName = "aaa", HireDate = DateTime.Now, EmpImage = @"D:\WPFPractice2\WPFPractice2\WpfApp2\WpfApp_Class\PokemonGo\pic_002.png" });
            empList.Add(new Class_Employee { EmpName = "bbb", HireDate = DateTime.Now.AddDays(-10), EmpImage = @"D:\WPFPractice2\WPFPractice2\WpfApp2\WpfApp_Class\PokemonGo\pic_003.png" });
            empList.Add(new Class_Employee { EmpName = "ccc", HireDate = DateTime.Now, EmpImage = @"D:\WPFPractice2\WPFPractice2\WpfApp2\WpfApp_Class\PokemonGo\pic_004.png" });
            this.listbox1.ItemsSource =this.listbox2.ItemsSource=this.listbox3.ItemsSource=  empList;

        }
    }
}
