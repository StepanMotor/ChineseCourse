﻿using System;
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
    /// Логика взаимодействия для AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
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

        private void PasswordPb_PasswordChanged_1()
        {

        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            LevelsWindow LevelsWindow = new LevelsWindow();
            LevelsWindow.Show();
            Close();
        }
    }
}
