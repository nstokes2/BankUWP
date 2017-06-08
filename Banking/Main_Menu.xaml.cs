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

namespace Banking
{
    /// <summary>
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Page
    {
        public Main_Menu()
        {
            InitializeComponent();
        }
        private void Withdrawal(object sender, RoutedEventArgs e)
        {

        }
        private void Deposit(object sender, RoutedEventArgs e)
        {
            

        }
        
        private void Balance_Inquiry(object sender, RoutedEventArgs e)
        {
            Balance_Inquiry balance_Inquiry = new Balance_Inquiry();
            NavigationService.Navigate(balance_Inquiry);
        }
        private void On_Exit(object sender, RoutedEventArgs e)
        {



            NavigationService.GoBack();
         
        }
    }
}
