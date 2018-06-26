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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Kirjaudu sisään painike
        //Jos käyttäjän antama käyttäjänimi ja salasana ovat hyväksyttyjä, päästetään käyttäjä käyttämään ohjelmaa
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //Luo uusi käyttäjä painike
        //Avaa uuden ikkunan jossa käyttäjä voi luoda uuden käyttäjätunnuksen
        private void NewUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
