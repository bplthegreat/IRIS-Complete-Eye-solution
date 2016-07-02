using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

    

        private void EyeCare_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EYE.xaml", UriKind.Relative));
        }


        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact Us.xaml", UriKind.Relative));
        }

        private void YellowPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Clinics.xaml", UriKind.Relative));
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/VisionTestor1.xaml", UriKind.Relative));
        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Ask Doctor.xaml", UriKind.Relative));
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Construction.xaml", UriKind.Relative));
        }

        private void Donation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Donation.xaml", UriKind.Relative));
        }










        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}