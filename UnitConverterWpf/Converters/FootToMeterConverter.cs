using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;
public class FootToMeterConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double foot))
        {
            double meter = foot * 0.3048; 
            return meter.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double meter))
        {
            double foot = meter * 3.2808;  
            return foot.ToString("N3");
        }

        return "";
    }
}
