using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace New.Base
{
    public class DictionaryConverter : IValueConverter
    {
        private readonly Dictionary _dictionary = new Dictionary();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return value;
            }
            var dic = _dictionary[parameter.ToString()];
            if (dic == null)
            {
                return value;
            }
            var strValue = value.ToString();
            foreach (var entity in dic)
            {
                if (entity.Code == strValue)
                {
                    return entity.Name;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return value;
            }
            var dic = _dictionary[parameter.ToString()];
            if (dic == null)
            {
                return value;
            }
            var strValue = value.ToString();
            foreach (var entity in dic)
            {
                if (entity.Name == strValue)
                {
                    return entity.Code;
                }
            }
            return value;
        }
    }

    public class DictionaryCodeToNameConvert : IValueConverter
    {
        private readonly DictionaryHelper _dictionarySource = DictionaryHelper.Instance;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return value;
            }
            var dicName = _dictionarySource[parameter.ToString(), value.ToString()];
            return dicName ?? value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
