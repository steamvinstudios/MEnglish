using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class PickerPage : Page
    {
        public Word RandomWord { get; set; }
        public List<Word> Words { get; set; }
        public List<Word> TrainerWords { get; set; } = new List<Word>();
        public PickerPage()
        {
            this.InitializeComponent();

            using (WordContext db = new WordContext())
            {
                Words = db.Words.ToList();
            }

            TrainerWords.Clear();

            for (int i = 0; i < 4; i++)
            {
                TrainerWords.Add(Words[new Random().Next(Words.Count - 1)]);
            }

            RandomWord = TrainerWords[new Random().Next(TrainerWords.Count - 1)];
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            answerButton1.Content = TrainerWords[0].EnglishForm;
            answerButton2.Content = TrainerWords[1].EnglishForm;
            answerButton3.Content = TrainerWords[2].EnglishForm;
            answerButton4.Content = TrainerWords[3].EnglishForm;
        }

        private void AnswerButton1_Click(object sender, RoutedEventArgs e)
        {
            CheckWords(sender);
        }

        private void AnswerButton2_Click(object sender, RoutedEventArgs e)
        {
            CheckWords(sender);
        }

        private void AnswerButton3_Click(object sender, RoutedEventArgs e)
        {
            CheckWords(sender);
        }

        private void AnswerButton4_Click(object sender, RoutedEventArgs e)
        {
            CheckWords(sender);
        }

        async void CheckWords(object sender)
        {
            if ((sender as Button).Content.ToString().Equals(RandomWord.EnglishForm))
            {
                var contentDialog = new ContentDialog
                {
                    Title = "Верно",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                RandomWord.LastRepeat = DateTime.Now;

                using (WordContext db = new WordContext())
                {
                    RandomWord.Rating += 5;
                    db.Words.Update(RandomWord);
                    db.SaveChanges();
                }
            }
            else
            {
                var contentDialog = new ContentDialog
                {
                    Title = "Ошибка",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                RandomWord.LastRepeat = DateTime.Now;

                using (WordContext db = new WordContext())
                {
                    db.Words.Update(RandomWord);
                    db.SaveChanges();
                }
            }
        }
    }
}
