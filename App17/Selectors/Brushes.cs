﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace App17.Selectors
{
    public class Brushes : DependencyObject
    {
        public static readonly DependencyProperty GoodBrushProperty =
        DependencyProperty.Register(
            "GoodBrush",
            typeof(Brush),
            typeof(Brushes), null
        );
        public Brush MyBrush
        {
            get { return (Brush)GetValue(GoodBrushProperty); }
            set { SetValue(GoodBrushProperty, (Brush)value); }
        }

        public Brushes() 
        {
            MyBrush = new SolidColorBrush(Colors.Tomato);
        }
    }
}
