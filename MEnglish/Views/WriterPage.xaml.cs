using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Networking.Sockets;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class WriterPage : Page
    {
        public AnswersResult AnswersResult { get; set; } = new AnswersResult();
        public TrainerStopwatch TrainerStopwatch { get; set; } = new TrainerStopwatch();
        public RandomWord RandomWord { get; set; } = new RandomWord();
        public List<Word> Words { get; set; }
        public WriterPage()
        {
            this.InitializeComponent();

            using (WordContext db = new WordContext())
            {
                Words = db.Words.ToList();
            }

            RandomWord.Word = Words[new Random().Next(Words.Count - 1)];
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void EnglishWordTextBlock_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            wordInfoTeachingTip.IsOpen = true;
        }

        private void EnglishWordTextBlock_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            wordInfoTeachingTip.IsOpen = false;
        }

        private async void CheckAnswerButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            if (answerTextBox.Text.ToLower().Equals(RandomWord.Word.RussianForm))
            {
                using (WordContext db = new WordContext())
                {
                    RandomWord.Word.Rating += 10;

                    if (RandomWord.Word.Rating >= 100)
                    {
                        RandomWord.Word.IsLearned = true;
                    }
                    else
                    {
                        RandomWord.Word.IsLearned = false;
                    }

                    db.Update(RandomWord.Word);
                    db.SaveChanges();
                }

                var contentDialog = new ContentDialog
                {
                    Title = "Верно",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                RandomWord.Word = Words[new Random().Next(Words.Count - 1)];

                answerTextBox.Text = "";

                AnswersResult.All++;
                AnswersResult.Correct++;

                wordInfoTeachingTip.IsOpen = false;
            }
            else
            {
                using (WordContext db = new WordContext())
                {
                    db.Update(RandomWord.Word);
                    db.SaveChanges();
                }

                var contentDialog = new ContentDialog
                {
                    Title = "Ошибка",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                AnswersResult.All++;
                AnswersResult.Mistakes++;

                wordInfoTeachingTip.IsOpen = true;
            }
        }
    }
}
