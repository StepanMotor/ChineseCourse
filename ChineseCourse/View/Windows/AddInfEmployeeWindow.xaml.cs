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
    /// Логика взаимодействия для AddInfEmployeeWindow.xaml
    /// </summary>
    public partial class AddInfEmployeeWindow : Window
    {
        public AddInfEmployeeWindow()
        {
            InitializeComponent();
            RoleCmb.SelectedValuePath = "id";
            RoleCmb.DisplayMemberPath = "Name";
           // RoleCmb.ItemsSource = App.context.Role.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
            Close();
        }
    }
}
