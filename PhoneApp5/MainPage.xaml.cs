using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp5.Resources;
using Windows.UI;
using System.Windows.Threading;

namespace PhoneApp5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {  //OnClick making progress bar visible
            ProBar.Visibility = Visibility.Visible;
            //intialize a timer
            DispatcherTimer timer = new DispatcherTimer();
            //Set time aacording to your need,here it is set to 6 Seconds
            timer.Interval = TimeSpan.FromSeconds(6);
            //subcribe to tick event and do whatever you want to do when this event is trigerred
            timer.Tick += (s, arg) =>
            {
                ProBar.Visibility = Visibility.Collapsed;
                timer.Stop();
                LoginButton.Content = "User Logged In";
            };
            //Start the timer and wait for x seconds to trigger tick event.
            timer.Start();

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