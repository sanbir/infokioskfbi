using App1.Common;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
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
using Windows.UI.ApplicationSettings;

// Документацию по шаблону "Приложение таблицы" см. по адресу http://go.microsoft.com/fwlink/?LinkId=234226

namespace App1
{
    /// <summary>
    /// Обеспечивает зависящее от конкретного приложения поведение, дополняющее класс Application по умолчанию.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Инициализирует одноэлементный объект приложения.  Это первая строка разрабатываемого кода
        /// кода; поэтому она является логическим эквивалентом main() или WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Вызывается при обычном запуске приложения пользователем.  Будут использоваться другие точки входа,
        /// будет использоваться, например, если приложение запускается для открытия конкретного файла.
        /// </summary>
        /// <param name="e">Сведения о запросе и обработке запуска.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs e)
        {

#if DEBUG
            // Отображение сведений о профиле графики во время отладки.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Отображение текущих счетчиков частоты смены кадров
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Не повторяйте инициализацию приложения, если в окне уже имеется содержимое,
            // только обеспечьте активность окна

            if (rootFrame == null)
            {
                // Создание фрейма, который станет контекстом навигации, и переход к первой странице
                rootFrame = new Frame();
                //Связывание фрейма с ключом SuspensionManager                                
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");
                // Задайте язык по умолчанию
                rootFrame.Language = Windows.Globalization.ApplicationLanguages.Languages[0];

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Восстановление сохраненного состояния сеанса только при необходимости
                    try
                    {
                        await SuspensionManager.RestoreAsync();
                    }
                    catch (SuspensionManagerException)
                    {
                        //Возникли ошибки при восстановлении состояния.
                        //Предполагаем, что состояние отсутствует, и продолжаем
                    }
                }

                // Размещение фрейма в текущем окне
                Window.Current.Content = rootFrame;
            }
            if (rootFrame.Content == null)
            {
                // Если стек навигации не восстанавливается для перехода к первой странице,
                // настройка новой страницы путем передачи необходимой информации в качестве параметра
                // навигации
                rootFrame.Navigate(typeof(GroupedItemsPage), e.Arguments);
            }
            // Обеспечение активности текущего окна
            Window.Current.Activate();
        }

        /// <summary>
        /// Вызывается в случае сбоя навигации на определенную страницу
        /// </summary>
        /// <param name="sender">Фрейм, для которого произошел сбой навигации</param>
        /// <param name="e">Сведения о сбое навигации</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Вызывается при приостановке выполнения приложения.  Состояние приложения сохраняется
        /// без учета информации о том, будет ли оно завершено или возобновлено с неизменным
        /// содержимым памяти.
        /// </summary>
        /// <param name="sender">Источник запроса приостановки.</param>
        /// <param name="e">Сведения о запросе приостановки.</param>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }

        public static async Task updateUserName(TextBlock userName, Boolean signIn)
        {
            try
            {
                // Open Live Connect SDK client.
                LiveAuthClient LCAuth = new LiveAuthClient();
                LiveLoginResult LCLoginResult = await LCAuth.InitializeAsync();
                try
                {
                    LiveLoginResult loginResult = null;
                    if (signIn)
                    {
                        // Sign in to the user's Microsoft account with the required scope.
                        //  
                        //  This call will display the Microsoft account sign-in screen if 
                        //   the user is not already signed in to their Microsoft account 
                        //   through Windows 8.
                        // 
                        //  This call will also display the consent dialog, if the user has 
                        //   has not already given consent to this app to access the data 
                        //   described by the scope.
                        // 
                        //  Change the parameter of LoginAsync to include the scopes 
                        //   required by your app.
                        loginResult = await LCAuth.LoginAsync(new string[] { "wl.basic" });
                    }
                    else
                    {
                        // If we don't want the user to sign in, continue with the current 
                        //  sign-in state.
                        loginResult = LCLoginResult;
                    }
                    if (loginResult.Status == LiveConnectSessionStatus.Connected)
                    {
                        // Create a client session to get the profile data.
                        LiveConnectClient connect = new LiveConnectClient(LCAuth.Session);

                        // Get the profile info of the user.
                        LiveOperationResult operationResult = await connect.GetAsync("me");
                        dynamic result = operationResult.Result;
                        if (result != null)
                        {
                            // Update the text of the object passed in to the method. 
                            userName.Text = string.Join(" ", "Hello", result.name, "!");
                        }
                        else
                        {
                            // Handle the case where the user name was not returned. 
                        }
                    }
                    else
                    {
                        // The user hasn't signed in so display this text 
                        //  in place of his or her name.
                        userName.Text = "You're not signed in.";
                    }
                }
                catch (LiveAuthException exception)
                {
                    // Handle the exception. 
                }
            }
            catch (LiveAuthException exception)
            {
                // Handle the exception. 
            }
            catch (LiveConnectException exception)
            {
                // Handle the exception. 
            }
        }

    }
}
