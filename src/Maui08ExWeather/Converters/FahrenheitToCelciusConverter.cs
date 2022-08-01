using System;
using System.Globalization;

namespace Maui08ExWeather.Converters
{
    public class FahrenheitToCelciusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double? fahrenheit = value as double?;
            if (fahrenheit == null)
                fahrenheit = 0;

            double celcius = (double)((fahrenheit - 32) * 5 / 9);

            return Math.Round(celcius).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

