using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;

public class PoundToKilogramConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double pound))
        {
            double kilogram = pound * 0.4535;
            return kilogram.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double kilogram))
        {
            double pound = kilogram * 2.2050;
            return pound.ToString("N3");
        }

        return "";
    }
}
