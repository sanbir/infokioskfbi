using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для NewsWindow.xaml
    /// </summary>
    public partial class NewsWindow : Window
    {
        Window parentWnd;

        public NewsWindow(Window wnd)
        {
            InitializeComponent();
            parentWnd = wnd;
            this.Top = wnd.Top;
            this.Left = wnd.Left;
            browser.Navigate(Directory.GetCurrentDirectory()+@"\news.htm");
            WindowState = WindowState.Maximized;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            parentWnd.Show();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
