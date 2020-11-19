using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SimpleHmi.Converters
{
    /// <summary>
    /// Class used to convert bool to visibility
    /// </summary>
    class BooleanToBrushConverter : IValueConverter

    {
        /// <summary>
        /// Convert bool to visibility
        /// </summary>
        /// <param name="value">bool value to be converted</param>
        /// <param name="targetType">target type</param>
        /// <param name="parameter">parameter</param>
        /// <param name="culture">Culture info</param>
        /// <returns>Visibility value</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? state = value as bool?;
            if (state == null)
                return Brushes.Gray;

            if (state == true)
                return Brushes.LimeGreen;

            return Brushes.Gray;
        }

        /// <summary>
        /// Convert back visibility to bool
        /// </summary>
        /// <param name="value">visibility value</param>
        /// <param name="targetType">target type</param>
        /// <param name="parameter">parameter</param>
        /// <param name="culture">Culture info</param>
        /// <returns>bool value</returns>

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
