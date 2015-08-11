using IVR.ViewModels;
using Microsoft.Windows.Controls.Ribbon;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IVR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private GroupsViewModel vm
        {
           get { return this.Resources["viewModel"] as GroupsViewModel;  }
        }

        public MainWindow()
        {
            InitializeComponent();
            IVRServiceReference.ServiceClient ctx = new IVRServiceReference.ServiceClient();
            
        }
    }
}
