using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Microsoft.Live;
using System.Threading.Tasks;

// Шаблон всплывающего элемента параметров задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=273769

namespace App1
{
    public sealed partial class Account : SettingsFlyout
    {
        public Account()
        {
            this.InitializeComponent();
            SetNameField(false);
        }

        private async void signInBtn_Click(object sender, RoutedEventArgs e)
        {
            // This call will sign the user in and update the Account flyout UI.
            await SetNameField(true);
        }

        private async void signOutBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Initialize access to the Live Connect SDK.
                LiveAuthClient LCAuth = new LiveAuthClient();
                LiveLoginResult LCLoginResult = await LCAuth.InitializeAsync();
                // Sign the user out, if he or she is connected;
                //  if not connected, skip this and just update the UI
                if (LCLoginResult.Status == LiveConnectSessionStatus.Connected)
                {
                    LCAuth.Logout();
                }

                // At this point, the user should be disconnected and signed out, so
                //  update the UI.
                this.userName.Text = "You're not signed in.";

                // Show sign-in button.
                signInBtn.Visibility = Windows.UI.Xaml.Visibility.Visible;
                signOutBtn.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            catch (LiveConnectException x)
            {
                // Handle exception.
            }
        }

        private async Task SetNameField(Boolean login)
        {
            // If login == false, just update the name field. 
            await App.updateUserName(this.userName, login);

            // Test to see if the user can sign out.
            Boolean userCanSignOut = true;

            LiveAuthClient LCAuth = new LiveAuthClient();
            LiveLoginResult LCLoginResult = await LCAuth.InitializeAsync();

            if (LCLoginResult.Status == LiveConnectSessionStatus.Connected)
            {
                userCanSignOut = LCAuth.CanLogout;
            }

            if (this.userName.Text.Equals("You're not signed in."))
            {
                // Show sign-in button.
                signInBtn.Visibility = Windows.UI.Xaml.Visibility.Visible;
                signOutBtn.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else
            {
                // Show sign-out button if they can sign out.
                signOutBtn.Visibility = (userCanSignOut ? Windows.UI.Xaml.Visibility.Visible : Windows.UI.Xaml.Visibility.Collapsed);
                signInBtn.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }
    }
    
}
