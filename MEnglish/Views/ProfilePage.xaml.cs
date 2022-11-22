using MEnglish.Models;
using MEnglish.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Data.Json;
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
        private ProfilePageViewModel viewModel = new ProfilePageViewModel();

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

        private void AddButton_Click(object sender, RoutedEventArgs e) =>
            Frame.Navigate(typeof(WordPage), null, new DrillInNavigationTransitionInfo());

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

        private void wordsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            wordsManagerTeachingTip.IsOpen = true;
        }
    }
}
