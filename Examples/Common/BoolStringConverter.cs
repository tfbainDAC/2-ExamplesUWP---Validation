using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;  // to allow the use of interface IValueConverter

namespace Examples.Common
{
    internal class BoolStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //return value.ToString();
            if (value.ToString().Equals("True"))
            {
                return "valid response entered";
            }
            else
            {
                return "please enter a valid value";
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return bool.Parse(value.ToString());
        }
    }
}
