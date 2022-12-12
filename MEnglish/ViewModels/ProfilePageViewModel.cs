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
using System.Reflection;

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
                    var suitableItems = new List<Word>();
                    var splitText = SearchTextBoxText.ToLower().Split(" ");
                    foreach (var word in db.Words)
                    {
                        var found = splitText.All((key) =>
                        {
                            var wordInfo = $"{word.EnglishForm} {word.RussianForm} {word.Rating}";
                            return wordInfo.ToLower().Contains(key);
                        });
                        if (found)
                        {
                            suitableItems.Add(word);
                        }
                    }

                    WordListItemsSource = suitableItems;


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
    }
}
