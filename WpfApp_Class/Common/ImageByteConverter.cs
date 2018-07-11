using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Common
{
    public class ImageByteConverter : IValueConverter
    {

        //byte[] to ImageSource
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (value == null) return null;
                BitmapImage biImg = new BitmapImage();
                MemoryStream ms = new MemoryStream((byte[])value);
                biImg.BeginInit();
                biImg.StreamSource = ms;
                biImg.EndInit();

                ImageSource imgSrc = biImg as ImageSource;

                return imgSrc;
            }
            catch
            {
                return null;
            }

        }

        //ImageSource to byte[]
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (value == null) return null;
                BitmapSource imageC = (BitmapSource)value;
                MemoryStream memStream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(imageC));
                encoder.Save(memStream);
                return memStream.ToArray();
            }

            catch
            {
                return null;
            }

        }
    }
   
}
