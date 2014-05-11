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
    public class MyTheme
    {
        public Brush LogoBrush { get; set; }
        public Brush BackBrush { get; set; }
        public Brush TileBackBrush { get; set; }
        public Brush TileFrontBrush { get; set; }
        public Brush PopupBrush { get; set; }

        private static List<MyTheme> myThemeStaticList = new List<MyTheme>() 
                {
                    new MyTheme()
                    {
                        LogoBrush = new SolidColorBrush(Colors.Pink),
                        BackBrush = new SolidColorBrush(Colors.Blue)
                    },
                    new MyTheme()
                    {
                        LogoBrush = new SolidColorBrush(Colors.Brown),
                        BackBrush = new SolidColorBrush(Colors.Cyan)
                    },
                    new MyTheme()
                    {
                        LogoBrush = new SolidColorBrush(Colors.Olive),
                        BackBrush = new SolidColorBrush(Colors.Orange)
                    }
                };

        public static MyThemesNames CurrentThemeName { get; set; }

        public static MyTheme CurrentTheme 
        {
            get
            {
                return myThemeStaticList[(int)CurrentThemeName];
            }
        }
    }

    public enum MyThemesNames 
    {
        Blue,
        Red,
        Green,
        Orange,
        Cyan,
        Violet
    }
}
