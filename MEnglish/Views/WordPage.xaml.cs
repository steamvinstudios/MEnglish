using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class WordPage : Page
    {
        Word word;
        public WordPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                int id = (int)e.Parameter;
                using (WordContext db = new WordContext())
                {
                    word = db.Words.FirstOrDefault(c => c.Id == id);
                }
            }

            if (word != null)
            {
                //headerBlock.Text = "Редактирование компании";
                imageBox.Text = word.Image;
                dateBox.Date = word.LastRepeat;
                ratingSlider.Value = word.Rating;
                isLearnedToggle.IsOn = word.IsLearned;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (WordContext db = new WordContext())
            {
                if (word != null)
                {
                    word.Image = imageBox.Text;
                    word.LastRepeat = dateBox.Date.DateTime;
                    word.Rating = (int)ratingSlider.Value;
                    word.IsLearned = isLearnedToggle.IsOn;
                    db.Words.Update(word);
                }
                else
                {
                    db.Words.Add(new Word { Image = imageBox.Text, LastRepeat = dateBox.Date.DateTime, Rating = (int)ratingSlider.Value, IsLearned = isLearnedToggle.IsOn });
                }
                db.SaveChanges();
            }
            GoToMainPage();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            GoToMainPage();
        }

        private void GoToMainPage()
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
            else
                Frame.Navigate(typeof(ProfilePage));
        }
    }
}
