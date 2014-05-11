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
        public static readonly DependencyProperty GoodBrushProperty =
        DependencyProperty.Register(
            "GoodBrush",
            typeof(Brush),
            typeof(MyTheme), null
        );
        public Brush GoodBrush
        {
            get { return (Brush)GetValue(GoodBrushProperty); }
            set { SetValue(GoodBrushProperty, (Brush)value); }
        }

        public static MyTheme MyBrushStaticObject = new MyTheme();
    }
}
