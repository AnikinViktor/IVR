using IVRClient.DataModel;
using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.ViewModels
{
    class GroupsViewModel : BaseViewModel
    {
        private ObservableCollection<Group> _Groups = new ObservableCollection<Group>();

        public ObservableCollection<Group> Groups
        {
            get { return this._Groups;  }
            set
            {
                this._Groups = value;
                RaisePropertyChanged("Groups");
            }
        }

        protected override object LoadData(DoWorkEventArgs e)
        {
            return new ObservableCollection<Group>(Group.Convert(Helper.I.Srv.GetGroupsWithPersons()));
        }

        protected override void SetLoadingResult(RunWorkerCompletedEventArgs e)
        {
            Groups = (ObservableCollection<Group>)e.Result;
        }
    }
}
