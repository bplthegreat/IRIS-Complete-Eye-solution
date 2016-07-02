using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PhoneApp1
{
    public partial class Eyecare : PhoneApplicationPage
    {
        public Eyecare()
        {
            InitializeComponent();
        }

        private void CALL_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();

            phoneCallTask.PhoneNumber = "9843223439";
            phoneCallTask.DisplayName = "Tilganga";

            phoneCallTask.Show();
        }
    }
}