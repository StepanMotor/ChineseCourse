using ChineseCourse.Model1;
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
    /// Логика взаимодействия для LookUserWindow.xaml
    /// </summary>
    public partial class LookUserWindow : Window
    {
        List<User> user = App.context.User.ToList();
        public LookUserWindow()
        {
            InitializeComponent();
            UsersLv.ItemsSource = App.context.User.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            Close();
        }
    }
}
