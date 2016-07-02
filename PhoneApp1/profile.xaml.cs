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
    public partial class profile : PhoneApplicationPage
    {
        public profile()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EYE.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact us.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Defects.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

  
    }
}