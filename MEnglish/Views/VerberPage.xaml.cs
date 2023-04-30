using MEnglish.Models;
using MEnglish.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class VerberPage : Page
    {
        private VerberPageViewModel viewModel { get; set; } = new VerberPageViewModel();
        public Verb Verb { get; set; } = new Verb();
        public ObservableCollection<Verb> Verbs { get; set; } = new ObservableCollection<Verb>();
        public VerberPage()
        {
            this.InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                Verbs.Add(viewModel.Verbs.Collection[new Random().Next(viewModel.Verbs.Collection.Count)]);
            }
            Verb = Verbs[new Random().Next(Verbs.Count)];
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            using (var db = new HistoryContext())
            {
                var result = viewModel.PickerTrainer.AnswersResult;
                db.Results.Add(result);
                db.Histories.Add(new History
                {
                    Correct = result.Correct.ToString(),
                    Mistakes = result.Mistakes.ToString(),
                    All = result.All.ToString(),
                    TrainerInfo = "Вербер"
                });
                db.SaveChanges();
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            viewModel.PickerTrainer.AnswersResult.IncreaseAll();

            if ((sender as Button).Content.ToString() == Verb.English)
            {
                viewModel.PickerTrainer.AnswersResult.IncreaseCorrect();

                Verbs.Clear();

                for (int i = 0; i < 4; i++)
                {
                    Verbs.Add(viewModel.Verbs.Collection[new Random().Next(viewModel.Verbs.Collection.Count)]);
                }

                Verb = Verbs[new Random().Next(Verbs.Count)];
                buildWordTextBlock.Text = Verb.Russian;
                AnswersListView.ItemsSource = Verbs;
            }
            else
            {
                viewModel.PickerTrainer.AnswersResult.IncreaseMistakes();

                var contentDialog = new ContentDialog
                {
                    Title = "Подсказка",
                    FontSize = 32,
                    Content = $"{Verb.Russian} - {Verb.English}",
                    CloseButtonText = "Попробовать еще"
                };

                var result = await contentDialog.ShowAsync();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
