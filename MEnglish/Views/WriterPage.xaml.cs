using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using MEnglish.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using Windows.System;
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
        private WriterPageViewModel viewModel = new WriterPageViewModel();
        public WriterPage() =>
            this.InitializeComponent();

        private void EnglishWordTextBlock_PointerEntered(object sender, PointerRoutedEventArgs e) =>
            viewModel.WriterTrainer.WordInfoTeachingTipIsOpen = true;

        private void EnglishWordTextBlock_PointerExited(object sender, PointerRoutedEventArgs e) =>
            viewModel.WriterTrainer.WordInfoTeachingTipIsOpen = false;

        private void CheckAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.WriterTrainer.IsNextTrainer)
            {
                Frame.Navigate(typeof(PickerPage));
            }
            viewModel.WriterTrainer.CheckAnswerAsync();
        }

        private void AnswerTextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
                viewModel.WriterTrainer.CheckAnswerAsync();
        }
    }
}
