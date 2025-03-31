using ChineseCourse.Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddInfEmployeeWindow.xaml
    /// </summary>
    public partial class AddInfEmployeeWindow : Window
    {
        public AddInfEmployeeWindow()
        {
            InitializeComponent();
            RoleCmb.SelectedValuePath = "id";
            RoleCmb.DisplayMemberPath = "Name";
            RoleCmb.ItemsSource = App.context.Role.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(FirstNameTb.Text))
            {
                mes += "Введите имя\n";
            }
            if (string.IsNullOrWhiteSpace(LastNameTb.Text))
            {
                mes += "Введите фамилию\n";
            }
            if (string.IsNullOrWhiteSpace(PatronymicTb.Text))
            {
                mes += "Введите отчество\n";
            }
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                mes += "Введите логин\n";
            }
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                mes += "Введите пароль\n";
            }
            if (string.IsNullOrWhiteSpace(levelTb.Text))
            {
                mes += "Введите уровень\n";
            }
            if (string.IsNullOrWhiteSpace(RoleCmb.Text))
            {
                mes += "Выберите роль\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Role selectedRole = RoleCmb.SelectedItem as Role;
            if (selectedRole == null)
            {
                MessageBox.Show("Ошибка выбора группы");
                return;
            }

            User user = new User()
            {
                Name = FirstNameTb.Text,
                Surname = LastNameTb.Text,
                Patronymic = PatronymicTb.Text,
                Login = LoginTb.Text,
                Password = PasswordTb.Text,
                Level = Convert.ToInt32(levelTb.Text),
                Role1 = App.context.Role.FirstOrDefault(r => r.Name == RoleCmb.Text),
            };
            App.context.User.Add(user);
            App.context.SaveChanges();
            MessageBox.Show("Сотрудник добавлен");

            FirstNameTb.Text = "";
            LastNameTb.Text = "";
            PatronymicTb.Text = "";
            LoginTb.Text = "";
            PasswordTb.Text = "";
            levelTb.Text = "";
            RoleCmb.Text = "";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
            Close();
        }
    }
}
