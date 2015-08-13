using IVR.DataModel;
using IVR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IVR
{
    /// <summary>
    /// Логика взаимодействия для PersonInfo.xaml
    /// </summary>
    public partial class PersonInfo : Window
    {
        private PersonInfoViewModel vm
        {
            get { return this.Resources["viewModel"] as PersonInfoViewModel; }
        }

        public PersonInfo(Person person)
        {
            InitializeComponent();
            this.vm.Person = person;
            this.Title = person.FIO;
        }
    }
}
