using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications; // Notifications library
using System.Numerics;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class TrainerMode : Page
    {
        Random random = new Random();
        public Vector3 GridVectorForShadow { get; set; } = new Vector3(0, 0, 32);
        public TrainerMode()
        {
            this.InitializeComponent();

        }
        private void ShortTrainBt_Click(object sender, RoutedEventArgs e)
        {
            TrainerModel.timesAmount = 3;
            TrainerModel.trainEnabled = true;
            MainProBar.MainProBarLocal.Maximum = 3 * 2;
            MainProBar.MainProBarLocal.Value = 0;
            Frame.Navigate(typeof(MainPage));
        }

        private void MidTrainBt_Click(object sender, RoutedEventArgs e)
        {
            TrainerModel.timesAmount = 5;
            TrainerModel.trainEnabled = true;
            MainProBar.MainProBarLocal.Maximum = 5 * 2;
            MainProBar.MainProBarLocal.Value = 0;
            Frame.Navigate(typeof(MainPage));
        }

        private void LongTrainBt_Click(object sender, RoutedEventArgs e)
        {
            TrainerModel.timesAmount = 7;
            TrainerModel.trainEnabled = true;
            MainProBar.MainProBarLocal.Maximum = 7 * 2;
            MainProBar.MainProBarLocal.Value = 0;
            Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PickFromFour));
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var posSnow = 0;
            MainProBar.MainProBarLocal.Value = 0;
            MainProBar.MainProBarLocal.Maximum = 0;

            var myPage = sender as TrainerMode;
            //myPage.Background = GlobalUISettings.BgAcr;

        }

        private void Grid_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ShortTrainBt.Translation += GridVectorForShadow;
        }

        private void backLandGrid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ShortTrainBt.Translation -= GridVectorForShadow;
        }
    }
}
