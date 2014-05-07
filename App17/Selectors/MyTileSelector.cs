﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using App17.Data;

namespace App17.Selectors
{
    class MyTileSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            SampleDataItem selectedItem = item as SampleDataItem;
            String template;
            
            if (true)
            {
                template = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                <Grid HorizontalAlignment=""Left"" Width=""250"" Height=""250"">
                    <Border Background=""{StaticResource ListViewItemPlaceholderBackgroundThemeBrush}"">
                        <Grid>
                            <Image Source=""{Binding ImagePath}"" Stretch=""UniformToFill"" AutomationProperties.Name=""{Binding Title}""/>
                            <Viewbox Margin=""10"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"">
                                <Path Fill=""{StaticResource MyBlueGrafient}"" Data=""{Binding Icon}"" 
                                                            Stretch=""Uniform""  
                                                            Width=""26"" Height=""26"" 
                                                            Margin=""0"" RenderTransformOrigin=""0.5,0.5"">
                                </Path>
                            </Viewbox>
                        </Grid>
                    </Border>
                    <StackPanel VerticalAlignment=""Bottom"" Background=""{StaticResource ListViewItemOverlayBackgroundThemeBrush}"">
                        <TextBlock Text=""{Binding Title}"" Foreground=""{StaticResource ListViewItemOverlayForegroundThemeBrush}"" Style=""{StaticResource TitleTextStyle}"" Height=""60"" Margin=""15,0,15,0""/>
                        <TextBlock Text=""{Binding Subtitle}"" Foreground=""{StaticResource ListViewItemOverlaySecondaryForegroundThemeBrush}"" Style=""{StaticResource CaptionTextStyle}"" TextWrapping=""NoWrap"" Margin=""15,0,15,10""/>
                    </StackPanel>
                </Grid>
            </DataTemplate>";
            }
            else
            {
                template = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    <TextBox Text=""Элемент отображается неправильно"" FontSize=""50"" />
                </DataTemplate>";
            }

            return XamlReader.Load(template) as DataTemplate;
        }
    }
}
