using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента страницы элементов задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234233

namespace MyUniversity
{
    /// <summary>
    /// Страница, на которой отображается коллекция эскизов элементов.  В приложении с разделением эта страница
    /// служит для отображения и выбора одной из доступных групп.
    /// </summary>
    public sealed partial class MainPage : MyUniversity.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        /// <summary>
        /// Заполняет страницу содержимым, передаваемым в процессе навигации. Также предоставляется любое сохраненное состояние
        /// при повторном создании страницы из предыдущего сеанса.
        /// </summary>
        /// <param name="navigationParameter">Значение параметра, передаваемое
        /// <see cref="Frame.Navigate(Type, Object)"/> при первоначальном запросе этой страницы.
        /// </param>
        /// <param name="pageState">Словарь состояния, сохраненного данной страницей в ходе предыдущего
        /// сеанса. Это значение будет равно NULL при первом посещении страницы.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Назначение привязываемой коллекции элементов объекту this.DefaultViewModel["Items"]

            // Список факультетов университета.
            // Чтобы расширить данные измените источник в DataModel/SampleDataSource.cs
            var strList = new List<Structure>();
            strList.Add(new Structure("Group-1", "Images/small/izdat.jpg", "Издательского дела, журналистики и рекламы", "Гуманитарне направление"));
            strList.Add(new Structure("Group-2", "Images/small/it.jpg", "Полиграфических технологий и оборудования", "Техническое направление"));
            strList.Add(new Structure("Group-3", "Images/small/up.jpg", "Центр переподготовки и повышения квалификации", "Техническое направление"));

            this.DefaultViewModel["Items"] = strList;
        }

        private void FacClicked(object sender, ItemClickEventArgs e)
        {
            var itemId = ((Structure)e.ClickedItem).UniqueId;

            // Переход к соответствующей странице назначения и настройка новой страницы
            // путем передачи необходимой информации в виде параметра навигации
            this.Frame.Navigate(typeof(GroupDetailPage), itemId);
        }

        private void MainInfoTapped(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UniversityInfo));
        }
    }
}
