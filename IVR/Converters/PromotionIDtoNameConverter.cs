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
    /// Конвертирует ID в название поощрения, ориентируясь по общей модели представления
    /// </summary>
    class PromotionIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PromotionType promotionType = CommonViewModel.I.PromotionTypes.SingleOrDefault(x => x.ID == (int)value);
            if (promotionType == null)
                return string.Empty;
            else
                return promotionType.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
