using IVRClient.DataModel;
using IVRClient.LoadResults;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.ViewModels
{
    class CommonViewModel : BaseViewModel
    {
        /// <summary>
        /// Статический экземпляр для доступа к модели представления из конвертеров
        /// </summary>
        public static CommonViewModel I = new CommonViewModel();

        #region PenaltyTypes
        private static ObservableCollection<PenaltyType> _PenaltyTypes = new ObservableCollection<PenaltyType>();
        public ObservableCollection<PenaltyType> PenaltyTypes
        {
            get
            {
                return _PenaltyTypes;
            }
            set
            {
                _PenaltyTypes = value;
                RaisePropertyChanged("PenaltyTypes");
            }
        }
        #endregion

        #region PromotionTypes
        private static ObservableCollection<PromotionType> _PromotionTypes = new ObservableCollection<PromotionType>();
        public ObservableCollection<PromotionType> PromotionTypes
        {
            get
            {
                return _PromotionTypes;
            }
            set
            {
                _PromotionTypes = value;
                RaisePropertyChanged("PromotionTypes");
            }
        }
        #endregion

        #region Ranks
        private static ObservableCollection<Rank> _Ranks = new ObservableCollection<Rank>();
        public ObservableCollection<Rank> Ranks
        {
            get
            {
                return _Ranks;
            }
            set
            {
                _Ranks = value;
                RaisePropertyChanged("Ranks");
            }
        }
        #endregion

        #region Organizations
        private static ObservableCollection<Organization> _Organizations = new ObservableCollection<Organization>();
        public ObservableCollection<Organization> Organizations
        {
            get
            {
                return _Organizations;
            }
            set
            {
                _Organizations = value;
                RaisePropertyChanged("Organizations");
            }
        }
        #endregion

        protected override LoadParams PrepareLoadParams()
        {
            // Проверяем надо ли загружать справочники
            bool loadDictionaries = _PromotionTypes.Count == 0 || _PenaltyTypes.Count == 0 || _Ranks.Count == 0 || _Organizations.Count == 0;

            // Загружаем справочники, если это необходимо
            if (loadDictionaries == false)
                return new LoadParams(true);
            else
                return new LoadParams(false);
        }

        protected override object LoadData(DoWorkEventArgs e)
        {
            CommonViewModelResult result = new CommonViewModelResult();

            result.PromotionTypes = new ObservableCollection<PromotionType>(PromotionType.Convert(AppState.I.Srv.GetPromotionTypes()));
            result.PenaltyTypes = new ObservableCollection<PenaltyType>(PenaltyType.Convert(AppState.I.Srv.GetPenaltyTypes()));
            result.Ranks = new ObservableCollection<Rank>(Rank.Convert(AppState.I.Srv.GetRanks()));
            result.Organizations = new ObservableCollection<Organization>(Organization.Convert(AppState.I.Srv.GetOrganizationInitiators(AppState.I.IDOrganization)));

            return result;
        }

        protected override void SetLoadingResult(RunWorkerCompletedEventArgs e)
        {
            CommonViewModelResult result = (CommonViewModelResult)e.Result;

            this.PenaltyTypes = result.PenaltyTypes;
            this.PromotionTypes = result.PromotionTypes;
            this.Ranks = result.Ranks;
            this.Organizations = result.Organizations;
        }
    }
}
