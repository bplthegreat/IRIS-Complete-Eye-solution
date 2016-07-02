using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class HyperMetropia : PhoneApplicationPage
    {
        public HyperMetropia()
        {
            InitializeComponent();
        }

        private void correct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Correct vision.xaml", UriKind.Relative));
        }

        private void wrong1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/wrong.xaml", UriKind.Relative));
        }
    }
}