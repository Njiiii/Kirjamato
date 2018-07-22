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

        private void SaveNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            //SAVE GIVEN ACCOUNTINFO TO THE USER DATABASE
            AccountSavedNotification.Visibility = Visibility.Visible;
        }

        private void ExitToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            //CLOSE ACCOUNT CREATION WINDOW
        }
    }
}
