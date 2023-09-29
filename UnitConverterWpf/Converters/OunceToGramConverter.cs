using System;
using System.Globalization;
using System.Windows.Data;

namespace UnitConverterWpf.Converters;
public class OunceToGramConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double ounce))
        {
            double gram = ounce * 28.35;
            return gram.ToString("N3");
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.TryParse((string)value, out double gram))
        {
            double ounce = gram * 0.0352;
            return ounce.ToString("N3");
        }    

        return "";
    }
}