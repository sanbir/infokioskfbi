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
        //public DataTemplate WebBrowserTemplate { get; set; }
        //public DataTemplate PhotoTemplate { get; set; }
        //public DataTemplate MsWordTemplate { get; set; }
        //public DataTemplate MsExcelTemplate { get; set; }
        //public DataTemplate UserStandardTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            SampleDataItem selectedItem = item as SampleDataItem;
            String template;

            if (selectedItem.ItemType == "browser") 
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    <WebView />
                </DataTemplate>";
            }
            else if (selectedItem.ItemType == "photo")
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    <Image Source=""{Binding ImagePath}"" />
                </DataTemplate>";
            }
            else if (selectedItem.ItemType == "word")
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    
                </DataTemplate>";
            }
            else if (selectedItem.ItemType == "excel")
            {
                template = @"
                <DataTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
                    
                </DataTemplate>";
            }
            else if (selectedItem.ItemType == "user")
            {
                template = @"";
            }
            else 
            {
                template = "";
            }

            return XamlReader.Load(template) as DataTemplate;
        }
    }
}
