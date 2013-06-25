using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace _01_MultiBindingDemo
{
    public class SliderValuesToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var red = System.Convert.ToByte(values[0]);
            var green = System.Convert.ToByte(values[1]);
            var blue = System.Convert.ToByte(values[2]);
            var alpha = System.Convert.ToByte(values[3]);
            var newColor = new Color()
            {
                R = red,
                G = green,
                B = blue,
                A = alpha
            };
            if (targetType.Name == "Brush")
            {
                
               return new SolidColorBrush(newColor);
            }
            return newColor.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
