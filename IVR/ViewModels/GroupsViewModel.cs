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
        private ObservableCollection<GroupContract> groups = new ObservableCollection<GroupContract>();

        public ObservableCollection<GroupContract> Groups
        {
            get { return this.groups;  }
            set
            {
                this.groups = value;
                RaisePropertyChanged("Groups");
            }
        }

        public bool IsSelected
        {
            set { LoadData(); }
        }

        public override void LoadData()
        {
            Groups = new ObservableCollection<GroupContract>(Helper.I.Srv.GetGroups());
        }
    }
}
