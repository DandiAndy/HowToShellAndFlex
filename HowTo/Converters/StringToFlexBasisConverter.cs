using System;
using System.Globalization;
using Xamarin.Forms;

namespace HowTo.Converters
{
    public class StringToFlexBasisConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string s)
            {
                return new FlexBasis((int)Application.Current.Resources[s]);
            }

            return new FlexBasis();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
