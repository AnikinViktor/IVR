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
    /// Конвертирует ID в название организации, ориентируясь по общей модели представления
    /// </summary>
    class OrganizationIDToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Organization organization = CommonViewModel.I.Organizations.SingleOrDefault(x => x.ID == (int)value);
            if (organization == null)
                return string.Empty;
            else
                return organization.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
