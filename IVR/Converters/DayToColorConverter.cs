using IVRClient.Calendar;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace IVRClient.Converters
{
    /// <summary>
    /// Конвертирует день недели (суббота и воскресенье) в красный цвет. Остальные дни черные.
    /// </summary>
    class DayToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Day day = (Day)value;
            if (day == null || (day.GetDay.DayOfWeek != DayOfWeek.Saturday && day.GetDay.DayOfWeek != DayOfWeek.Sunday))
                return Brushes.Black;
            else


                return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
