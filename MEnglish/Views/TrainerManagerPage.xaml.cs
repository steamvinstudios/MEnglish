﻿using MEnglish.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class TrainerManagerPage : Page
    {
        private TrainerManagerViewModel viewModel = new TrainerManagerViewModel();
        public TrainerManagerPage()
        {
            this.InitializeComponent();
            Content = viewModel.CurrentPageFrame;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NextTrainerPageEvery2Seconds();
        }

        private async void NextTrainerPageEvery2Seconds()
        {
            while (true)
            {
                await Task.Delay(3000);
                viewModel.CurrentPageFrame.Content = viewModel.WriterPage;
                await Task.Delay(3000);
                viewModel.CurrentPageFrame.Content = viewModel.PickerPage;
            }
        }
    }
}
