using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace App17.Selectors
{
    public class MyTheme : DependencyObject
    {
        public Brush LogoBrush { get; set; }
        public Brush BackBrush { get; set; }
        public Brush TileBackBrush { get; set; }
        public Brush TileFrontBrush { get; set; }
        public Brush PopupBrush { get; set; }

        public static List<MyTheme> MyThemeStaticList { get; set; }
    }
}
