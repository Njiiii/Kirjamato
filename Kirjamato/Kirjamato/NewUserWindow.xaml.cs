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

namespace Kirjamato
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void saveNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            //SAVE NEW USERS INFO TO DATABASE

        }

        private void BackToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            //CLOSES USER CREATION WINDOW

        }
    }
}
