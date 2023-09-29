using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;

internal class YardToMeterConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double yard))
        {
            double meter = yard * 0.9144;
            return meter.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double meter))
        {

            double yard = meter * 1.0936;
            return yard.ToString("N3");
        }

        return "";
    }
}
