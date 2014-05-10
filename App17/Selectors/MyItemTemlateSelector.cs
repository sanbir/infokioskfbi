using System;
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
    class MyItemTemlateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            SampleDataItem selectedItem = item as SampleDataItem;
            String template;

            if (selectedItem.ItemType == "browser") 
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    <WebView Source="""
                    + selectedItem.ImagePath
                    + @""" />
                </DataTemplate>";
            }
            else if (selectedItem.ItemType == "photo")
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    <Image Source=""{Binding ImagePath}"" />
                </DataTemplate>";
            }
            else if (selectedItem.ItemType == "user")
            {
                template = @"<DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:common='using:App17.Common'>
                        <ScrollViewer Style=""{StaticResource HorizontalScrollViewerStyle}"" Grid.Row=""1"">
                            <common:RichTextColumns Margin=""117,0,117,47"" VerticalAlignment=""Top"">
                                <RichTextBlock Width=""560"" Style=""{StaticResource ItemRichTextStyle}"" IsTextSelectionEnabled=""False"">
                                    <Paragraph>
                                        <Run FontSize=""26.667"" FontWeight=""Light"" Text=""{Binding Title}""/>
                                        <LineBreak/>
                                        <LineBreak/>
                                        <Run FontWeight=""Normal"" Text=""{Binding Subtitle}""/>
                                    </Paragraph>
                                    <Paragraph LineStackingStrategy=""MaxHeight"">
                                        <InlineUIContainer>
                                            <Image MaxHeight=""480"" Width=""300"" Margin=""0,20,0,10"" Stretch=""Uniform"" Source=""{Binding ImagePath}"" AutomationProperties.Name=""{Binding Title}""/>
                                        </InlineUIContainer>
                                    </Paragraph>
                                    <Paragraph>
                                        <Run FontWeight=""SemiLight"" Text=""{Binding Content}""/>
                                    </Paragraph>
                                </RichTextBlock>
                                <common:RichTextColumns.ColumnTemplate>
                                    <DataTemplate>
                                        <RichTextBlockOverflow Width=""560"" Margin=""80,0,0,0"">
                                            <RichTextBlockOverflow.RenderTransform>
                                                <TranslateTransform X=""-1"" Y=""4""/>
                                            </RichTextBlockOverflow.RenderTransform>
                                        </RichTextBlockOverflow>
                                    </DataTemplate>
                                </common:RichTextColumns.ColumnTemplate>
                            </common:RichTextColumns>
                        </ScrollViewer>
                    </DataTemplate>";
            }
            else if (selectedItem.ItemType == "launch")
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    <Button Content=""Открыть документ"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" FontSize=""40""  />
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
