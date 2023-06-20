using System.Globalization;

namespace PersonenDatenbank.Model;

public class GenderConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return Gender.NOT_DEFINED;

        if (value is not int)
            throw new ArgumentException("GenderConverter argument not supported. Only integer is supported for convertion.");
        
        return (Gender)value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Gender)
        {
            return (byte)value;
        }

        return 0;
    }
}