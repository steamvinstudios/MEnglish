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
        public TrainerMode()
        {
            this.InitializeComponent();
            //this.NavigationCacheMode = NavigationCacheMode.Enabled; // кэш страницы вкл.

        }
        private void ShortTrainBt_Click(object sender, RoutedEventArgs e)
        {
            TrainerModel.timesAmount = 3;
            TrainerModel.trainEnabled = true;
            MainProBar.MainProBarLocal.Maximum = 3*2;
            MainProBar.MainProBarLocal.Value = 0;
            Frame.Navigate(typeof(MainPage));
        }

        private void MidTrainBt_Click(object sender, RoutedEventArgs e)
        {
            TrainerModel.timesAmount = 5;
            TrainerModel.trainEnabled = true;
            MainProBar.MainProBarLocal.Maximum = 5*2;
            MainProBar.MainProBarLocal.Value = 0;
            Frame.Navigate(typeof(MainPage));
        }

        private void LongTrainBt_Click(object sender, RoutedEventArgs e)
        {
            TrainerModel.timesAmount = 7;
            TrainerModel.trainEnabled = true;
            MainProBar.MainProBarLocal.Maximum = 7*2;
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
        //-------------------------------------------------------------------------------------
        //------------------------СТРАНИЦА ЗАГРУЖЕНА-------------------------------------------
        //-------------------------------------------------------------------------------------
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var posSnow = 0;
            MainProBar.MainProBarLocal.Value = 0;
            MainProBar.MainProBarLocal.Maximum = 0;
            //StGdTipAnim();

            // АНИМАЦИЯ СНЕЖИНОК

            /*while (true)
            {
                await Task.Delay(120);
                var rnd = new Random();
                sn1.Translation = new Vector3(rnd.Next(posSnow, 1280), rnd.Next(posSnow, 1280), 0);
                posSnow++;
            }*/

        }
        /*async void StGdTipAnim()
        {
            await Task.Delay(1000);
            StartGuideTip.Title = "Совет";
            StartGuideTip.Subtitle = "Выбор режима";
            StartGuideTip.Content = new TextBlock
            {
                Text = "Выбери один из режимов тренировки",
                FontSize = 24,
                TextWrapping = TextWrapping.Wrap,
                Foreground = new SolidColorBrush(Color.FromArgb(255, (byte)random.Next(150, 256), (byte)random.Next(150, 256), (byte)random.Next(150, 256)))
            };
            StartGuideTip.Target = ShortTrainBt;
            StartGuideTip.IsOpen = true;
            await Task.Delay(2000);
            StartGuideTip.IsOpen = false;
            await Task.Delay(500);
            StartGuideTip.Content = new TextBlock
            {
                Text = "Ты пройдешь несколько тренажеров подряд",
                FontSize = 24,
                TextWrapping = TextWrapping.Wrap,
                Foreground = new SolidColorBrush(Color.FromArgb(255, (byte)random.Next(150, 256), (byte)random.Next(150, 256), (byte)random.Next(150, 256)))
            };
            StartGuideTip.Target = MidTrainBt;
            StartGuideTip.IsOpen = true;
            await Task.Delay(2000);
            StartGuideTip.IsOpen = false;
            await Task.Delay(500);
            StartGuideTip.Content = new TextBlock
            {
                Text = "И заработаешь очки",
                FontSize = 24,
                TextWrapping = TextWrapping.Wrap,
                Foreground = new SolidColorBrush(Color.FromArgb(255, (byte)random.Next(150, 256), (byte)random.Next(150, 256), (byte)random.Next(150, 256)))
            };
            StartGuideTip.Target = LongTrainBt;
            StartGuideTip.IsOpen = true;
            await Task.Delay(2000);
            StartGuideTip.IsOpen = false;
            await Task.Delay(500);
            StartGuideTip.Title = "Совет";
            StartGuideTip.Subtitle = "Наставление";
            StartGuideTip.Content = new TextBlock
            {
                Text = "Удачи!",
                FontSize = 32,
                Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 50, 70))
            };
            StartGuideTip.Target = null;
            StartGuideTip.IsOpen = true;
            await Task.Delay(2000);
            StartGuideTip.IsOpen = false;
        }*/
    }
}
