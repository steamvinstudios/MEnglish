using MEnglish.Models;
using MEnglish.ViewModels;
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
    public sealed partial class SentencesPage : Page
    {
        private SentencesPageViewModel viewModel = new SentencesPageViewModel();
        public Sentence Sentence { get; set; } = new Sentence();
        public List<string> EnSenSplited { get; set; } = new List<string>();
        public SentencesPage()
        {
            this.InitializeComponent();

            Sentence = viewModel.Sentences.Collection[new Random().Next(viewModel.Sentences.Collection.Count)];

            EnSenSplited = Sentence.English.Split(' ').ToList().OrderBy(x => new Random().Next()).ToList();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            wordTextBox.Text += $"{(sender as Button).Content} ";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wordTextBox.Text.TrimEnd() == Sentence.English)
            {
                viewModel.PickerTrainer.AnswersResult.IncreaseAll();
                viewModel.PickerTrainer.AnswersResult.IncreaseCorrect();

                /*
                var contentDialog = new ContentDialog
                {
                    Title = "Отличный результат 💚",
                    FontSize = 32,
                    Content = $"{Sentence.Russian} - {Sentence.English}",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();
                */

                Sentence = viewModel.Sentences.Collection[new Random().Next(viewModel.Sentences.Collection.Count)];

                EnSenSplited = Sentence.English.Split(' ').ToList().OrderBy(x => new Random().Next()).ToList();

                buildWordTextBlock.Text = Sentence.Russian;
                AnswersListView.ItemsSource = EnSenSplited.ToList();

                wordTextBox.Text = "";
            }
            else
            {
                viewModel.PickerTrainer.AnswersResult.IncreaseAll();
                viewModel.PickerTrainer.AnswersResult.IncreaseMistakes();

                var contentDialog = new ContentDialog
                {
                    Title = "Подсказка",
                    FontSize = 32,
                    Content = $"{Sentence.Russian} - {Sentence.English}",
                    CloseButtonText = "Попробовать еще"
                };

                var result = await contentDialog.ShowAsync();

                wordTextBox.Text = "";
            }
        }
    }
}
