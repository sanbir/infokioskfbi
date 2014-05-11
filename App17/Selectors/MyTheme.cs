using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace App17.Selectors
{
    public class MyTheme
    {
        //public Brush MyBackgroundBrush { get; set; }
        //public Brush MyTileBackBrush { get; set; }
        //public Brush MyTileFrontBrush { get; set; }
        public Brush MyLogoBrush { get; set; }
        //public Brush MySolidBrush { get; set; }

        public static List<MyTheme> GetThemes()
        {
            List<MyTheme> Themes = new List<MyTheme>();
            //String xamlString;
            //MyTheme theme;

//            theme = new MyTheme();
//            xamlString = @"<LinearGradientBrush EndPoint=""0.5,1"" StartPoint=""0.5,0"">
//                                <GradientStop Color=""#FF081E4D"" Offset=""0""/>
//                                <GradientStop Color=""#FF1747B0"" Offset=""0.23""/>
//                                <GradientStop Color=""#FF2161EC"" Offset=""0.433""/>
//                                <GradientStop Color=""#FF5A8AF1"" Offset=""0.77""/>
//                                <GradientStop Color=""#FFC0CFF0"" Offset=""0.993""/>
//                            </LinearGradientBrush>";
//            theme.MyLogoBrush = XamlReader.Load(xamlString) as LinearGradientBrush;
//            Themes.Add(theme);

//            theme = new MyTheme();
//            xamlString = @"<LinearGradientBrush EndPoint=""0.5,1"" StartPoint=""0.5,0"">
//                                <GradientStop Color=""#FF360500"" Offset=""0""/>
//                                <GradientStop Color=""#FF680A00"" Offset=""0.23""/>
//                                <GradientStop Color=""#FFA41000"" Offset=""0.433""/>
//                                <GradientStop Color=""#FFFB1900"" Offset=""0.77""/>
//                                <GradientStop Color=""#FFFFCFC0"" Offset=""0.993""/>
//                            </LinearGradientBrush>";
//            theme.MyLogoBrush = XamlReader.Load(xamlString) as LinearGradientBrush;
//            Themes.Add(theme);

            Themes.Add(new MyTheme() { MyLogoBrush = new SolidColorBrush(Colors.Blue) });
            Themes.Add(new MyTheme() { MyLogoBrush = new SolidColorBrush(Colors.Red) });
            Themes.Add(new MyTheme() { MyLogoBrush = new SolidColorBrush(Colors.Yellow) });
            Themes.Add(new MyTheme() { MyLogoBrush = new SolidColorBrush(Colors.Pink) });
            Themes.Add(new MyTheme() { MyLogoBrush = new SolidColorBrush(Colors.Violet) });

            return Themes;
        }

        public static MyTheme SelectedTheme
        {
            get;
            set;
        }
    }
}
