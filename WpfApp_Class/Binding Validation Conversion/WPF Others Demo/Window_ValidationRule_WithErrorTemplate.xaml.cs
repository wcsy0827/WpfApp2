using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace WpfApplication1.Common
{

    /// <summary>
    /// Window_Validation.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Validation : Window
    {
        public Window_Validation()
        {
            InitializeComponent();


            this.DataContext = new MyTestClass { StartDate = DateTime.Now, Range = 8, Age = 8 };

        }


  
    }     
    //===========================
        //View model Here
        class MyTestClass : INotifyPropertyChanged
        {

            public DateTime StartDate { get; set; }

            public int Range { get; set; }

            private int m_Age;
            public int Age
            {
                get
                { return m_Age; }
                set
                {
                    m_Age = value;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Age"));

                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }


}
