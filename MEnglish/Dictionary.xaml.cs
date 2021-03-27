using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Dictionary : Page
    {
        public int StackMargin { get; set; }
        public Words Words { get; set; } = new Words();
        Image ttipContentImage = new Image()
        {
            MaxWidth = 120,
            MaxHeight = 120,
            Source = new BitmapImage 
            {
                UriSource = new Uri("ms-appx:///ArrayPics/book.jpg")
            } 
        };
        public Dictionary()
        {
            this.InitializeComponent();
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ttip.IsOpen = true;
            var lView = sender as ListView;
            var currentItem = (Word)lView.SelectedItem;
            ttip.Title = currentItem.OriginalWord;
            ttip.Subtitle = currentItem.WordTranslation.ToString();
            ttip.Target = mainAB;
        }

        // Handle text change and present suitable items
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var suitableItems = new List<string>();
            var splitText = sender.Text.ToLower().Split(" ");
            foreach (var word in Words.WordsArray)
            {
                var found = splitText.All((key) =>
                {
                    return word.OriginalWord.ToLower().Contains(key);
                });
                if (found)
                {
                    suitableItems.Add(word.OriginalWord);
                }
            }
            if (suitableItems.Count == 0)
            {
                suitableItems.Add("Не найдено");
            }
            sender.ItemsSource = suitableItems;
        }
        // Handle user selecting an item, in our case just output the selected item.
        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            ttip.IsOpen = true;
            var currentItem = args.SelectedItem.ToString();
            Word GetWord()
            {
                Word tmpWord = new Word();
                foreach (var word in Words.WordsArray)
                {
                    if (word.OriginalWord == currentItem)
                    {
                        tmpWord = word;
                    }
                }
                return tmpWord;
            }
            ttip.Title = GetWord().OriginalWord;
            ttip.Subtitle = GetWord().WordTranslation.ToString();
            ttip.Target = mainAB;
        }

        private void GDic_Loaded(object sender, RoutedEventArgs e)
        {
            GDic.Background = GlobalUISettings.BgAcr;
        }
    }
}
