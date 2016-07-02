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
    public partial class Contact_us : PhoneApplicationPage
    {
        public Contact_us()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void HyperlinkButton_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact Us.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FeedPage.xaml", UriKind.Relative));
        }
    }
}