using ChineseCourse.View.Windows.Test1;
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
    /// Логика взаимодействия для LevelsWindow.xaml
    /// </summary>
    public partial class LevelsWindow : Window
    {
        public LevelsWindow()
        {
            InitializeComponent();
        }

        private void Level1Btn_Click(object sender, RoutedEventArgs e)
        {
            Test1.InstructionsTestWindow instructionsTestWindow = new InstructionsTestWindow();
            instructionsTestWindow.Show();
            Close();
        }
    }
}
