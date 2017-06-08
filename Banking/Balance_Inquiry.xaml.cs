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
    /// Interaction logic for Balance_Inquiry.xaml
    /// </summary>
    public partial class Balance_Inquiry : Page
    {
        public Balance_Inquiry()
        {
            InitializeComponent();

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            
        }
        private void Go_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
