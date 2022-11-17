using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public RandomWordPicker RandomWordPicker { get; set; } = new RandomWordPicker();
        public FourRandomWords FourRandomWords { get; set; }
        public AnswersResult AnswersResult { get; set; } = new AnswersResult();
        public TrainerStopwatch TrainerStopwatch { get; set; } = new TrainerStopwatch();
        public List<Word> Words { get; set; }
        public PickerPage()
        {
            this.InitializeComponent();

            using (WordContext db = new WordContext())
            {
                Words = db.Words.ToList();
            }

            FourRandomWords = new FourRandomWords();
            RandomWordPicker.Word = FourRandomWords.Words[new Random().Next(FourRandomWords.Words.Count - 1)];
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

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
            if ((sender as Button).Content.ToString().Equals(RandomWordPicker.Word.EnglishForm))
            {
                RandomWordPicker.Word.LastRepeat = DateTime.Now;

                using (WordContext db = new WordContext())
                {
                    RandomWordPicker.Word.Rating += 40;

                    if (RandomWordPicker.Word.Rating >= 100 && RandomWordPicker.Word.IsLearned == false)
                    {
                        RandomWordPicker.Word.IsLearned = true;
                        wordProgressTeachingTip.IsOpen = true;
                        await Task.Delay(2000);
                        wordProgressTeachingTip.IsOpen = false;
                        await Task.Delay(1000);
                    }

                    db.Words.Update(RandomWordPicker.Word);
                    db.SaveChanges();
                }

                AnswersResult.All++;
                AnswersResult.Correct++;

                using (WordContext db = new WordContext())
                {
                    Words = db.Words.ToList();
                }

                for (var i = 0; i < 4; i++)
                {
                    FourRandomWords.Words[i] = Words[new Random().Next(Words.Count - 1)];
                }

                RandomWordPicker.Word = FourRandomWords.Words[new Random().Next(FourRandomWords.Words.Count - 1)];
            }
            else
            {
                var contentDialog = new ContentDialog
                {
                    Title = "Ошибка",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                RandomWordPicker.Word.LastRepeat = DateTime.Now;

                using (WordContext db = new WordContext())
                {
                    db.Words.Update(RandomWordPicker.Word);
                    db.SaveChanges();
                }

                AnswersResult.All++;
                AnswersResult.Mistakes++;
            }
        }
    }
}
