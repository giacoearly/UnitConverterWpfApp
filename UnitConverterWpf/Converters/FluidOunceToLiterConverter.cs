using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;
public class FluidOunceToLiterConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double founce))
        {
            double liter = founce * 0.0284;
            return liter.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double liter))
        {
            double founce = liter * 35.2112;
            return founce.ToString("N3");
        }

        return "";
    }
}
