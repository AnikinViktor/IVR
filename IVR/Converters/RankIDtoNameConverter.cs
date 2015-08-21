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
    class RankIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Rank rank = CommonViewModel.I.Ranks.SingleOrDefault(x => x.ID == (int)value);
            if (rank == null)
                return string.Empty;
            else
                return rank.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
