using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace IVRClient.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заголовок кнопки добавления
        /// </summary>
        public string AddButtonTitle
        {
            get { return (string)this.GetValue(AddButtonTitleProperty); }
            set { this.SetValue(AddButtonTitleProperty, value); }
        }

        public static readonly DependencyProperty AddButtonTitleProperty =
            DependencyProperty.Register("AddButtonTitle", typeof(string), typeof(Buttons), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Заголовок кнопки редактирования
        /// </summary>
        public string EditButtonTitle
        {
            get { return (string)this.GetValue(EditButtonTitleProperty); }
            set { this.SetValue(EditButtonTitleProperty, value); }
        }

        public static readonly DependencyProperty EditButtonTitleProperty =
            DependencyProperty.Register("EditButtonTitle", typeof(string), typeof(Buttons), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Заголовок кнопки удаления
        /// </summary>
        public string DeleteButtonTitle
        {
            get { return (string)this.GetValue(DeleteButtonTitleProperty); }
            set { this.SetValue(DeleteButtonTitleProperty, value); }
        }

        public static readonly DependencyProperty DeleteButtonTitleProperty =
            DependencyProperty.Register("DeleteButtonTitle", typeof(string), typeof(Buttons), new PropertyMetadata(string.Empty));
    }
}
