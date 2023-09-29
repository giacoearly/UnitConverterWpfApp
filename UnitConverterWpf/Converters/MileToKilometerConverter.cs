using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;

public class MileToKilometerConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double mile))
        {
            double kilometer = mile * 1.6093;
            return kilometer.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double kilometer))
        {
            double mile = kilometer * 0.6213;
            return mile.ToString("N3");
        }

        return "";
    }
}   