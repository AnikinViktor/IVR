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
    /// Результат загрузки данных в модель представления анкеты сотрудника
    /// </summary>
    class PersonInfoViewModelResult
    {
        public ObservableCollection<Work> Works { get; set; }

        public ObservableCollection<Promotion> Promotions { get; set; }

        public ObservableCollection<Penalty> Penalties { get; set; }

        public ObservableCollection<PersonRank> PersonRanks { get; set; }
    }
}
