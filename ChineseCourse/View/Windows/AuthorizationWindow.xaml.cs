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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
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

        private void RegistrationHp_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения из полей ввода
            string login = LoginTb.Text; // предполагая, что LoginTb - это TextBox
            string password = PasswordPb.Password; // предполагая, что PasswordPb - это PasswordBox

            // Проверка логина и пароля
            if (login == "admin" && password == "admin123")
            {
                ManagerWindow managerWindow = new ManagerWindow();
                managerWindow.Show();
                this.Close();
            }
            else if (login == "user" && password == "user123")
            {
                LevelsWindow levelsWindow = new LevelsWindow();
                levelsWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
