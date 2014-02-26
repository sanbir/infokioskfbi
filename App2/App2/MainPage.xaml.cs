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
using Windows.Security.Authentication.OnlineId;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Logout();
            SetNameField(false);
        }

        public async Task<bool> Logout()
        {
            // Check to see if the user can sign out (Live account or Local account)
            var onlineIdAuthenticator = new OnlineIdAuthenticator();
            var serviceTicketRequest = new OnlineIdServiceTicketRequest("wl.basic", "DELEGATION");
            await onlineIdAuthenticator.AuthenticateUserAsync(serviceTicketRequest);

            if (onlineIdAuthenticator.CanSignOut)
            {
                new LiveAuthClient().Logout();
            }

            return true;
        }



        private async void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            await SetNameField(true);
        }

        private async Task SetNameField(Boolean login)
        {
            await App.updateUserName(this.statusTextBlock, login);
            Boolean userCanSignOut = true;
            LiveAuthClient LCAuth = new LiveAuthClient();
            LiveLoginResult LCLoginResult = await LCAuth.InitializeAsync();
            if (LCLoginResult.Status == LiveConnectSessionStatus.Connected)
            {
                userCanSignOut = LCAuth.CanLogout;
            }
            if (this.statusTextBlock.Text.Equals("You're not signed in."))
            {
                loginBtn.Visibility = Windows.UI.Xaml.Visibility.Visible;
                logoutBtn.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else
            {
                logoutBtn.Visibility = (userCanSignOut ? Windows.UI.Xaml.Visibility.Visible : Windows.UI.Xaml.Visibility.Collapsed);
                loginBtn.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private async void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LiveAuthClient LCAuth = new LiveAuthClient();
                LiveLoginResult LCLoginResult = await LCAuth.InitializeAsync();
                if (LCLoginResult.Status == LiveConnectSessionStatus.Connected)
                {
                    LCAuth.Logout();
                }
                this.statusTextBlock.Text = "You're not signed in.";
                loginBtn.Visibility = Windows.UI.Xaml.Visibility.Visible;
                logoutBtn.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            catch (LiveConnectException x)
            {
            }
        }
    }
}
