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

namespace ChineseCourse.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AccountManagerWindow.xaml
    /// </summary>
    public partial class AccountManagerWindow : Window
    {
        public AccountManagerWindow()
        {
            InitializeComponent();
        }

        private void PasswordPb_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility =
       (sender as PasswordBox)?.Password.Length > 0
           ? Visibility.Collapsed
           : Visibility.Visible;
        }

        private void ManagerBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            Close();
        }
    }
}
