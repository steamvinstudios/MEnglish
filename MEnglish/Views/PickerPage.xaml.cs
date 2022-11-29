using MEnglish.Models;
using MEnglish.ViewModels;
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
        private PickerPageViewModel viewModel { get; set; } = new PickerPageViewModel();
        public PickerPage()
        {
            this.InitializeComponent();
        }

        private void AnswerButton1_Click(object sender, RoutedEventArgs e) =>
            viewModel.PickerTrainer.CheckWords(sender);

        private void AnswerButton2_Click(object sender, RoutedEventArgs e) =>
            viewModel.PickerTrainer.CheckWords(sender);

        private void AnswerButton3_Click(object sender, RoutedEventArgs e) =>
            viewModel.PickerTrainer.CheckWords(sender);

        private void AnswerButton4_Click(object sender, RoutedEventArgs e) =>
            viewModel.PickerTrainer.CheckWords(sender);
    }
}
