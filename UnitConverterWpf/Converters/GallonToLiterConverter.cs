using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;

public class GallonToLiterConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double gallon))
        {
            double liter = gallon * 4.5460;
            return liter.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double liter))
        {
            double gallon = liter * 0.2199;
            return gallon.ToString("N3");
        }

        return "";
    }
}    