using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1.Common
{
    //=================================


    [ValueConversion(typeof(Color), typeof(SolidColorBrush))]
    public class ColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color color = (Color)value;
            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }



    public class DoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double d;
            if (double.TryParse(value.ToString(), out d))
                return d;
            else
                return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
    public class YesNoToBooleanConverter : IValueConverter
    {
      
        //當來源物件 binding 到目標物件 時 (即目標要展現 data 時, 會 call   Convert 方法 => data (value) 格式化 展現出來

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
      {
            switch (value.ToString().ToLower())
            {
                case "yes":
                case "oui":
                    return true;
                case "no":
                case "non":
                    return false;
            }
            return false;
        }

        //當目標目件 binding update 回來源物件 時 => 會 call   ConvertBack 方法 =>設定到來源物件 binding 的 data

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value == true)
                    return "yes";
                else
                    return "no";
            }
            return "no";
        }
    }


}
