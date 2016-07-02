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
    public partial class linkup : PhoneApplicationPage
    {
        public linkup()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EYE.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/profile.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Defects.xaml", UriKind.Relative));
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Remedies.xaml", UriKind.Relative));
        }

    

        private void button_conjuctivi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EYE.xaml", UriKind.Relative));
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FeedPage.xaml", UriKind.Relative));
        }

        private void button_Cataract_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Cataract.xaml", UriKind.Relative));
        }
    }
}