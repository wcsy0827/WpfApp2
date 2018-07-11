using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Common
{
    public class PriceToForegroundConvertor : IValueConverter     
{
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
               
                var Price = System. Convert.ToDecimal( value);
                if (Price >= 100)
                    return new SolidColorBrush(Colors.Red);
                else
                    return new SolidColorBrush(Colors.Green);
            }
            catch
            {
                return new SolidColorBrush(Colors.Black);
            }
        }

     
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

      
   }     

}
