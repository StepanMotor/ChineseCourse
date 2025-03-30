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

namespace ChineseCourse.View.Windows.Test1
{
    /// <summary>
    /// Логика взаимодействия для Question4Window.xaml
    /// </summary>
    public partial class Question4Window : Window
    {
        public Question4Window()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            Test1.EndTestWindow endTestWindow = new EndTestWindow();
            endTestWindow.Show();
            Close();
        }
    }
}
