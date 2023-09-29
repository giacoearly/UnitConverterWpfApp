using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;

public class FahrenheitToCelsiusConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            return fahrenheit.ToString("N3");
        }

        return "";
    }
}
