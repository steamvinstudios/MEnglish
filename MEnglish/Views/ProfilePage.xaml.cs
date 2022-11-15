using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ProfilePage : Page
    {
        // тестовое
        public Words LocalWords { get; set; } = new Words();
        //
        public Words Words { get; set; } = new Words();
        public ProfilePage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (WordContext db = new WordContext())
            {
                wordsList.ItemsSource = db.Words.ToList();
            }
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WordPage), null, new DrillInNavigationTransitionInfo());
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделеный пункт меню
            if (wordsList.SelectedItem != null)
            {
                Word word = wordsList.SelectedItem as Word;
                if (word != null)
                    Frame.Navigate(typeof(WordPage), word.Id, new DrillInNavigationTransitionInfo());
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // получаем выделеный пункт меню
            if (wordsList.SelectedItem != null)
            {
                Word word = wordsList.SelectedItem as Word;
                if (word != null)
                {
                    using (WordContext db = new WordContext())
                    {
                        db.Words.Remove(word);
                        db.SaveChanges();
                        wordsList.ItemsSource = db.Words.ToList();
                    }
                }
            }
        }

        private void LoadDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            using (WordContext db = new WordContext())
            {
                wordsList.ItemsSource = db.Words.ToList();
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var httpClient = new HttpClient();
                var httpResponseMessage = await httpClient.GetAsync("https://steamvinstudios.github.io/");
                var responseBody = httpResponseMessage.Content.ReadAsStringAsync();

                var contentDialog = new ContentDialog
                {
                    Title = "С гитхаба",
                    Content = responseBody.Result,
                    CloseButtonText = "Закрыть",
                };

                var result = await contentDialog.ShowAsync();
            }
            catch (HttpRequestException h)
            {
                var contentDialog = new ContentDialog
                {
                    Title = "С гитхаба",
                    Content = new StackPanel
                    {
                        Children =
                        {
                            new TextBlock { Text = "Ошибка получения данных" },
                            new TextBlock { Text = h.Message, TextWrapping = TextWrapping.Wrap }
                        }
                    },
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();
            }
        }

        private void AddStartWordsButton_Click(object sender, RoutedEventArgs e)
        {
            using (WordContext db = new WordContext())
            {
                foreach (var word in LocalWords.All)
                {
                    db.Words.Add(word);
                }

                db.SaveChanges();
            }
        }
    }
}
