
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp_Class.XMAL_Language
{
    /// <summary>
    /// Window_MyNotepad.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyNotepad : Window
    {
        public Window_MyNotepad()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.textbox1.Cut();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.textbox1.Copy();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.textbox1.Paste();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush1 = new SolidColorBrush(Colors.Red);

            this.textbox1.Foreground =brush1;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush2 = new SolidColorBrush(Colors.Lime);

            this.textbox1.Foreground = brush2;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush3 = new SolidColorBrush(Colors.Blue);

            this.textbox1.Foreground = brush3;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush4 = new SolidColorBrush(Colors.Black);

            this.textbox1.Foreground = brush4;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 

                string filename = dlg.FileName;
                this.textbox1.Text = File.ReadAllText(filename);
            }
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            if (sfd.ShowDialog() == true)
                File.WriteAllText(sfd.FileName, textbox1.Text);
        }
    }
}
