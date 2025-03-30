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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
            Close();
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            LookUserWindow lookUserWindow = new LookUserWindow();
            lookUserWindow.Show();
            Close();
        }

        private void ManagerBtn_Click(object sender, RoutedEventArgs e)
        {
            AccountManagerWindow accountManagerWindow = new AccountManagerWindow();
            accountManagerWindow.Show();
            Close();
        }
    }
}
