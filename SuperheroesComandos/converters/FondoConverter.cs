using System;
using System.Globalization;
using System.Windows.Data;

namespace SuperheroesComandos
{
    class FondoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return "PaleGreen";
            else
                return "IndianRed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
