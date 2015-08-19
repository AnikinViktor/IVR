using IVRClient.ViewModels;
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

namespace IVRClient
{
    /// <summary>
    /// Логика взаимодействия для Calendar.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        private CalendarViewModel vm
        {
            get { return this.Resources["viewModel"] as CalendarViewModel; }
        }

        public CalendarWindow(DateTime startDate, DateTime stopDate)
        {
            InitializeComponent();
        }
    }
}
