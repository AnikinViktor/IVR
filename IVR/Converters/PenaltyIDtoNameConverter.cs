using IVRClient.DataModel;
using IVRClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace IVRClient.Converters
{
    /// <summary>
    /// Конвертирует ID в название взыскания, ориентируясь по общей модели представления
    /// </summary>
    class PenaltyIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PenaltyType penaltyType = CommonViewModel.I.PenaltyTypes.SingleOrDefault(x => x.ID == (int)value);
            if (penaltyType == null)
                return string.Empty;
            else
                return penaltyType.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
