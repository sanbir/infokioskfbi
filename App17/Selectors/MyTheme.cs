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
                        LogoBrush = XamlReader.Load(
                            @"<LinearGradientBrush 
                                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                                    EndPoint=""0.5,1"" StartPoint=""0.5,0"">
                                <GradientStop Color=""#FF081E4D"" Offset=""0""/>
                                <GradientStop Color=""#FF1747B0"" Offset=""0.23""/>
                                <GradientStop Color=""#FF2161EC"" Offset=""0.433""/>
                                <GradientStop Color=""#FF5A8AF1"" Offset=""0.77""/>
                                <GradientStop Color=""#FFC0CFF0"" Offset=""0.993""/>
                            </LinearGradientBrush>"
                        ) as LinearGradientBrush,
                        BackBrush = new SolidColorBrush(Colors.Blue),
                        TileBackBrush = new SolidColorBrush(Colors.Green),
                        TileFrontBrush = new SolidColorBrush(Colors.Red),
                        PopupBrush = new SolidColorBrush(Colors.Plum)
                    },
                    new MyTheme()
                    {
                        LogoBrush = XamlReader.Load(
                            @"<LinearGradientBrush 
                                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                                    EndPoint=""0.5,1"" StartPoint=""0.5,0"">
                                <GradientStop Color=""#FF360500"" Offset=""0""/>
                                <GradientStop Color=""#FF680A00"" Offset=""0.23""/>
                                <GradientStop Color=""#FFA41000"" Offset=""0.433""/>
                                <GradientStop Color=""#FFFB1900"" Offset=""0.77""/>
                                <GradientStop Color=""#FFFFCFC0"" Offset=""0.993""/>
                            </LinearGradientBrush>"
                        ) as LinearGradientBrush,
                        BackBrush = new SolidColorBrush(Colors.Red),
                        TileBackBrush = new SolidColorBrush(Colors.YellowGreen),
                        TileFrontBrush = new SolidColorBrush(Colors.WhiteSmoke),
                        PopupBrush = new SolidColorBrush(Colors.Wheat)
                    },
                    new MyTheme()
                    {
                        LogoBrush = XamlReader.Load(
                            @"<LinearGradientBrush 
                                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                                    EndPoint=""0.5,1"" StartPoint=""0.5,0"">
                                <GradientStop Color=""#FF013403"" Offset=""0""/>
                                <GradientStop Color=""#FF005503"" Offset=""0.23""/>
                                <GradientStop Color=""#FF007C04"" Offset=""0.433""/>
                                <GradientStop Color=""#FF00A805"" Offset=""0.77""/>
                                <GradientStop Color=""#FFC7F0C0"" Offset=""0.993""/>
                            </LinearGradientBrush>"
                        ) as LinearGradientBrush,
                        BackBrush = new SolidColorBrush(Colors.Orange),
                        TileBackBrush = new SolidColorBrush(Colors.White),
                        TileFrontBrush = new SolidColorBrush(Colors.Olive),
                        PopupBrush = new SolidColorBrush(Colors.PowderBlue)
                    },
                    new MyTheme()
                    {
                        LogoBrush = XamlReader.Load(
                            @"<LinearGradientBrush 
                                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                                    EndPoint=""0.5,1"" StartPoint=""0.5,0"">
                                <GradientStop Color=""#FF4D2408"" Offset=""0""/>
                                <GradientStop Color=""#FFB07F17"" Offset=""0.23""/>
                                <GradientStop Color=""#FFEC9921"" Offset=""0.433""/>
                                <GradientStop Color=""#FFF1C85A"" Offset=""0.77""/>
                                <GradientStop Color=""#FFF0E9C0"" Offset=""0.993""/>
                            </LinearGradientBrush>"
                        ) as LinearGradientBrush,
                        BackBrush = new SolidColorBrush(Colors.Blue),
                        TileBackBrush = new SolidColorBrush(Colors.Green),
                        TileFrontBrush = new SolidColorBrush(Colors.Red),
                        PopupBrush = new SolidColorBrush(Colors.Plum)
                    },
                    new MyTheme()
                    {
                        LogoBrush = XamlReader.Load(
                            @"<LinearGradientBrush 
                                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                                    EndPoint=""0.5,1"" StartPoint=""0.5,0"">
                                <GradientStop Color=""#FF084A4D"" Offset=""0""/>
                                <GradientStop Color=""#FF17A9B0"" Offset=""0.23""/>
                                <GradientStop Color=""#FF21ECE3"" Offset=""0.433""/>
                                <GradientStop Color=""#FF5AEAF1"" Offset=""0.77""/>
                                <GradientStop Color=""#FFC0EEF0"" Offset=""0.993""/>
                            </LinearGradientBrush>"
                        ) as LinearGradientBrush,
                        BackBrush = new SolidColorBrush(Colors.Blue),
                        TileBackBrush = new SolidColorBrush(Colors.Green),
                        TileFrontBrush = new SolidColorBrush(Colors.Red),
                        PopupBrush = new SolidColorBrush(Colors.Plum)
                    },
                    new MyTheme()
                    {
                        LogoBrush = XamlReader.Load(
                            @"<LinearGradientBrush 
                                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
                                    EndPoint=""0.5,1"" StartPoint=""0.5,0"">
                                <GradientStop Color=""#FF40084D"" Offset=""0""/>
                                <GradientStop Color=""#FFA217B0"" Offset=""0.23""/>
                                <GradientStop Color=""#FFBE21EC"" Offset=""0.433""/>
                                <GradientStop Color=""#FFF15AE3"" Offset=""0.77""/>
                                <GradientStop Color=""#FFF0C0EC"" Offset=""0.993""/>
                            </LinearGradientBrush>"
                        ) as LinearGradientBrush,
                        BackBrush = new SolidColorBrush(Colors.Blue),
                        TileBackBrush = new SolidColorBrush(Colors.Green),
                        TileFrontBrush = new SolidColorBrush(Colors.Red),
                        PopupBrush = new SolidColorBrush(Colors.Plum)
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
