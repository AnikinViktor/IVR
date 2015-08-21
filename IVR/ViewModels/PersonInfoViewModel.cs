using IVRClient.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using IVRClient.LoadResults;

namespace IVRClient.ViewModels
{
    /// <summary>
    /// Параметры загрузки данных в модель представления
    /// </summary>
    class PersonInfoViewModelLoadparams
    {
        /// <summary>
        /// Признак того, что необходимо загрузить справочники
        /// </summary>
        public bool LoadDictionaries { get; set; }
    }

    class PersonInfoViewModel : BaseViewModel
    {
        #region Person
        private Person _Person = null;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                RaisePropertyChanged("Person");
            }
        }
        #endregion

        #region Work
        private ObservableCollection<Work> _Works = new ObservableCollection<Work>();
        public ObservableCollection<Work> Works
        {
            get
            {
                return this._Works;
            }
            set
            {
                this._Works = value;
                RaisePropertyChanged("Works");
            }
        }
        #endregion

        #region Promotion
        private ObservableCollection<Promotion> _Promotions = new ObservableCollection<Promotion>();
        public ObservableCollection<Promotion> Promotions
        {
            get
            {
                return this._Promotions;
            }
            set
            {
                this._Promotions = value;
                RaisePropertyChanged("Promotions");
            }
        }
        #endregion

        #region Penalties
        private ObservableCollection<Penalty> _Penalties = new ObservableCollection<Penalty>();
        public ObservableCollection<Penalty> Penalties
        {
            get
            {
                return this._Penalties;
            }
            set
            {
                this._Penalties = value;
                RaisePropertyChanged("Penalties");
            }
        }
        #endregion

        #region PersonRanks
        private ObservableCollection<PersonRank> _PersonRanks = new ObservableCollection<PersonRank>();
        public ObservableCollection<PersonRank> PersonRanks
        {
            get
            {
                return this._PersonRanks;
            }
            set
            {
                this._PersonRanks = value;
                RaisePropertyChanged("PersonRanks");
            }
        }
        #endregion

        protected override object LoadData(DoWorkEventArgs e)
        {
            PersonInfoViewModelLoadparams param = (PersonInfoViewModelLoadparams)e.Argument;

            PersonInfoViewModelResult result = new PersonInfoViewModelResult();
            result.Works = new ObservableCollection<Work>(Work.Convert(AppState.I.Srv.GetWorks(Person.ID, AppState.I.Year)));
            result.Promotions = new ObservableCollection<Promotion>(Promotion.Convert(AppState.I.Srv.GetPromotions(Person.ID, AppState.I.Year)));
            result.Penalties = new ObservableCollection<Penalty>(Penalty.Convert(AppState.I.Srv.GetPenalties(Person.ID, AppState.I.Year)));
            result.PersonRanks = new ObservableCollection<PersonRank>(PersonRank.Convert(AppState.I.Srv.GetPersonRanks(Person.ID)));

            return result;
        }

        protected override void SetLoadingResult(RunWorkerCompletedEventArgs e)
        {
            PersonInfoViewModelResult result = (PersonInfoViewModelResult)e.Result;

            this.Works = result.Works;
            this.Promotions = result.Promotions;
            this.Penalties = result.Penalties;
            this.PersonRanks = result.PersonRanks;
        }
    }
}
