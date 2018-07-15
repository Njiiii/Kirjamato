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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kirjamato
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Login -button
        //If username and password are correct, user is given access to the rest of the program
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String givenAccountname = UsernameBox.Text;
            String givenPassword = PasswordBox.Password;


            
            
        }

        //Create new user -button
        //Opens a new window, where user can create a new account
        private void NewUserButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 userCreationWindow = new Window1();
            userCreationWindow.Show();
        }
    }
}
