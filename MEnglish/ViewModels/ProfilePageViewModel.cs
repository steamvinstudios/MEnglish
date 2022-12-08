using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using MEnglish.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml;
using System.Collections.ObjectModel;

namespace MEnglish.ViewModels
{
    public class ProfilePageViewModel : BaseViewModel
    {
        private List<Word> wordListItemsSource;
        public List<Word> WordListItemsSource
        {
            get => wordListItemsSource;
            set => SetProperty(ref wordListItemsSource, value);
        }
        private string searchTextBoxText = string.Empty;
        public string SearchTextBoxText
        {
            get => searchTextBoxText;
            set
            {
                SetProperty(ref searchTextBoxText, value);
                using (WordContext db = new WordContext())
                {
                    WordListItemsSource = db.Words.Where(w => w.EnglishForm == SearchTextBoxText).ToList();

                    if (string.IsNullOrWhiteSpace(SearchTextBoxText))
                    {
                        WordListItemsSource = db.Words.OrderByDescending(w => w.Rating).ToList();
                    }
                }
            }
        }
        public Words AppWords { get; set; } = new Words();
        public ProfilePageViewModel()
        {
            using (WordContext db = new WordContext())
            {
                WordListItemsSource = db.Words.OrderByDescending(w => w.Rating).ToList();
            }
        }

        // from ProfilePage
        // адаптировать для ViewModel
        // ------------------------------------------------------------------------------

        /*
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

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            using (WordContext db = new WordContext())
            {
                var tmpWords = db.Words.ToList();

                foreach (var word in tmpWords)
                    db.Words.Remove(word);

                db.SaveChanges();

                foreach (var word in viewModel.AppWords.All)
                    db.Add(word);

                db.SaveChanges();

                wordsList.ItemsSource = db.Words.ToList();
            }
        }
        // ------------------------------------------------------------------------------
        */
    }
}
