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
    /// Логика взаимодействия для InstructionsTestWindow.xaml
    /// </summary>
    public partial class InstructionsTestWindow : Window
    {
        public InstructionsTestWindow()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            Test1.Tone1Window tone1Window = new Tone1Window();
            tone1Window.Show();
            Close();
        }
    }
}
