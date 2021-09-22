using System;
using System.Globalization;
using Xamarin.Forms;

namespace HowTo.Converters
{
    public class PercentageToFlexBasisConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "S":
                    return new FlexBasis(0.25f, true);
                case "M":
                    return new FlexBasis(0.5f, true);
                case "L":
                    return new FlexBasis(1f, true);
                default:
                    return new FlexBasis();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
