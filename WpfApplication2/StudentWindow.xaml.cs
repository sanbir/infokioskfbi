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
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        Window mainWnd;
        Window currentWindow;

        public StudentWindow(Window wnd)
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

        private void newsBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new NewsWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void studyBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new StudyWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void aboutBtn_Click(object sender, RoutedEventArgs e)
        {
            currentWindow = new AboutWindow(this);
            currentWindow.Show();
            this.Hide();
        }

        private void libraryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
