using IVR.DataModel;
using IVR.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR.ViewModels
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

        public bool IsSelected
        {
            set { LoadData(); }
        }

        public override void LoadData()
        {
            Groups = new ObservableCollection<Group>(Group.Convert(Helper.I.Srv.GetGroups()));
        }
    }
}
