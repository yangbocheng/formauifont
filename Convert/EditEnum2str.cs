using System.Globalization;
using todomaui.Common;
using todomaui.Enums;

namespace todomaui.Convert;

public class EditEnum2str : IValueConverter
{
    public static EditEnum2str Instance = new EditEnum2str();
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var v = (EditEnum)value;
        switch (v)
        {
            case EditEnum.New:
                return "新建";
            case EditEnum.Edit:
                return "编辑";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}