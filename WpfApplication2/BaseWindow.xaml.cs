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
    /// Логика взаимодействия для BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        Window mainWnd;
        Window currentWindow;

        public BaseWindow(Window wnd)
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
    }
}
