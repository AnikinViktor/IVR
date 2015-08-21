using IVRClient.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.LoadResults
{
    /// <summary>
    /// Результаты загрузки данных в модель представления
    /// </summary>
    class CommonViewModelResult
    {
        public ObservableCollection<PromotionType> PromotionTypes { get; set; }

        public ObservableCollection<PenaltyType> PenaltyTypes { get; set; }

        public ObservableCollection<Rank> Ranks { get; set; }

        public ObservableCollection<Organization> Organizations { get; set; }
    }
}
