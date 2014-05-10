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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        Window mainWnd;
        Window currentWindow;

        public AboutWindow(Window wnd)
        {
            InitializeComponent();
            mainWnd = wnd;
            this.Top = wnd.Top;
            this.Left = wnd.Left;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWnd.Show();
        }


        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void aboutBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new DeanWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void photoBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new MissionWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void eventsBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new DepartmentsWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void studyBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new SpecWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void newsBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new BaseWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void restBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
