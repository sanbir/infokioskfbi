using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    public partial class MainWindow : Window
    {
        Window currentWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void studentEntry_Click(object sender, RoutedEventArgs e)
        {
            //currentWindow = new StudentWindow(this);
            //currentWindow.Show();
            //this.Hide();

            currentWindow = new LoginWnd();
            currentWindow.Owner = this;
            currentWindow.ShowDialog();
            //this.Hide();
        }

        private void teacherEntry_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new TeacherWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void guestEntry_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new GuestWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void themesCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();

            switch (themesCombobox.SelectedIndex)
            {
                case 0:
                    resourceDictionary.Source = new Uri("/Themes/DarkButton.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 1:
                    resourceDictionary.Source = new Uri("/Themes/ShinyBlue.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 2:
                    resourceDictionary.Source = new Uri("/Themes/BureauBlue.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 3:
                    resourceDictionary.Source = new Uri("/Themes/ShinyDarkPurple.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 4:
                    resourceDictionary.Source = new Uri("/Themes/UXMusingsBubblyBlue.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 5:
                    resourceDictionary.Source = new Uri("/Themes/UXMusingsGreen.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 6:
                    resourceDictionary.Source = new Uri("/Themes/UXMusingsRoughGreen.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case 7:
                    resourceDictionary.Source = new Uri("/Themes/RainierOrange.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    resourceDictionary.Source = new Uri("/Themes/BureauBlack.xaml", UriKind.RelativeOrAbsolute);
                    break;
            }

            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
