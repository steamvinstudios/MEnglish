﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class GenPoint : Page
    {
        public ViewModels.MVVMTestPageViewModel ViewModel { get; set; } =
            new ViewModels.MVVMTestPageViewModel();
        public GenPoint()
        {
            this.InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(AboutPage));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(PickFromFour));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(TrainerMode));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(TrainerMode));
            stackProBar.Children.Add(MainProBar.MainProBarLocal);
        }

        private void HideNavigationBarButton_Click(object sender, RoutedEventArgs e)
        {
            navigationBarStack.Visibility = Visibility.Collapsed;
            showNavigationBarButton.Visibility = Visibility.Visible;
        }

        private void ShowMavigationBarButton_Click(object sender, RoutedEventArgs e)
        {
            showNavigationBarButton.Visibility = Visibility.Collapsed;
            navigationBarStack.Visibility = Visibility.Visible;
        }

        private void WriterButton_Click(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(MainPage), ViewModel.Words);
        }
    }
}
