using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Notifications;
using System.Numerics;
using Windows.UI.Xaml.Media.Animation;
using MEnglish.ViewModels;
using MEnglish.Models;
using MEnglish.Views;
using MEnglish.Services;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public News News { get; set; }
        private HomePageViewModel viewModel = new HomePageViewModel();
        public HomePage()
        {
            this.InitializeComponent();
        }
        private void ShortTrainBt_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TrainerManagerPage), null, new DrillInNavigationTransitionInfo());
        }

        private void MidTrainBt_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WriterPage), null, new DrillInNavigationTransitionInfo());
        }

        private void LongTrainBt_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WriterPage), null, new DrillInNavigationTransitionInfo());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WriterPage), null, new DrillInNavigationTransitionInfo());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PickerPage), null, new DrillInNavigationTransitionInfo());
        }

        private async void LoadNewsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newsService = new NewsService();
                News = await newsService.GetNewsAsync("http://localhost:5000/news");
                JsonNewsListView.ItemsSource = News.All;

                var contentDialog = new ContentDialog
                {
                    Title = "Успешно",
                    Content = "Загрузка новостей выполнена",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                var contentDialog = new ContentDialog
                {
                    Title = "Сервер недоступен",
                    Content = $"Загрузка новостей не выполнена: {ex}",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();
            }
            
        }
    }
}
