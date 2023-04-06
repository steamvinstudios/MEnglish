using System;
using System.Collections.Generic;
using System.Drawing;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class PickFromFour : Page
    {
        Random random = new Random();
        int currentRuWord;
        int positiveBtClick = 0;
        public PickFromFour()
        {
            this.InitializeComponent();
            
        }

        async void GenerateNewWords()
        {
            while (true)
            {
                PickBt1.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(20, 0, 0, 0));
                PickBt2.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(20, 0, 0, 0));
                PickBt3.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(20, 0, 0, 0));
                PickBt4.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(20, 0, 0, 0));

                PickBt1.Content = JsonWords.EWArray[random.Next(0, JsonWords.RWArray.Length)];
                PickBt2.Content = JsonWords.EWArray[random.Next(0, JsonWords.RWArray.Length)];
                PickBt3.Content = JsonWords.EWArray[random.Next(0, JsonWords.RWArray.Length)];
                PickBt4.Content = JsonWords.EWArray[random.Next(0, JsonWords.RWArray.Length)];

                if (PickBt1.Content.ToString() == JsonWords.EWArray[currentRuWord])
                {
                    //PickBt1.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 0, 255, 0));
                    GreatBadJob.Content = JsonWords.GBArray[random.Next(0, JsonWords.GBArray.Length)];
                    GreatBadJob.Opacity = 1.0;
                    await Task.Delay(1000);
                    GreatBadJob.Opacity = 0.0;
                    break;
                }
                if (PickBt2.Content.ToString() == JsonWords.EWArray[currentRuWord])
                {
                    //PickBt2.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 0, 255, 0));
                    GreatBadJob.Content = JsonWords.GBArray[random.Next(0, JsonWords.GBArray.Length)];
                    GreatBadJob.Opacity = 1.0;
                    await Task.Delay(1000);
                    GreatBadJob.Opacity = 0.0;
                    break;
                }
                if (PickBt3.Content.ToString() == JsonWords.EWArray[currentRuWord])
                {
                    //PickBt3.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 0, 255, 0));
                    GreatBadJob.Content = JsonWords.GBArray[random.Next(0, JsonWords.GBArray.Length)];
                    GreatBadJob.Opacity = 1.0;
                    await Task.Delay(1000);
                    GreatBadJob.Opacity = 0.0;
                    break;
                }
                if (PickBt4.Content.ToString() == JsonWords.EWArray[currentRuWord])
                {
                    //PickBt4.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 0, 255, 0));
                    GreatBadJob.Content = JsonWords.GBArray[random.Next(0, JsonWords.GBArray.Length)];
                    GreatBadJob.Opacity = 1.0;
                    await Task.Delay(1000);
                    GreatBadJob.Opacity = 0.0;
                    break;
                }
            }
        }

        private void GenerateWords_Click(object sender, RoutedEventArgs e)
        {
            GenerateNewWords();
        }

        private void PickBt1_Click(object sender, RoutedEventArgs e)
        {
            if (PickBt1.Content.ToString() == JsonWords.EWArray[currentRuWord])
            {
                positiveBtClick += 1;
                if (TrainerModel.timesAmount == positiveBtClick && TrainerModel.trainEnabled == true)
                {
                    positiveBtClick = 0;
                    Frame.Navigate(typeof(GreatJob));
                }
                currentRuWord = random.Next(0, JsonWords.RWArray.Length);
                SomeEnWord.Text = JsonWords.RWArray[currentRuWord];
                BgImg.Source = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{JsonWords.EWArray[currentRuWord]}.jpg"));
                GenerateNewWords();
                MainProBar.MainProBarLocal.Value++;
            } else
            {
                PickBt1.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 255, 0, 0));
            }
        }

        private void PickBt2_Click(object sender, RoutedEventArgs e)
        {
            if (PickBt2.Content.ToString() == JsonWords.EWArray[currentRuWord])
            {
                positiveBtClick += 1;
                if (TrainerModel.timesAmount == positiveBtClick && TrainerModel.trainEnabled == true)
                {
                    positiveBtClick = 0;
                    Frame.Navigate(typeof(GreatJob));
                }
                currentRuWord = random.Next(0, JsonWords.RWArray.Length);
                SomeEnWord.Text = JsonWords.RWArray[currentRuWord];
                BgImg.Source = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{JsonWords.EWArray[currentRuWord]}.jpg"));
                GenerateNewWords();
                MainProBar.MainProBarLocal.Value++;
            }
            else
            {
                PickBt2.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 255, 0, 0));
            }
        }

        private void PickBt3_Click(object sender, RoutedEventArgs e)
        {
            if (PickBt3.Content.ToString() == JsonWords.EWArray[currentRuWord])
            {
                positiveBtClick += 1;
                if (TrainerModel.timesAmount == positiveBtClick && TrainerModel.trainEnabled == true)
                {
                    positiveBtClick = 0;
                    Frame.Navigate(typeof(GreatJob));
                }
                currentRuWord = random.Next(0, JsonWords.RWArray.Length);
                SomeEnWord.Text = JsonWords.RWArray[currentRuWord];
                BgImg.Source = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{JsonWords.EWArray[currentRuWord]}.jpg"));
                GenerateNewWords();
                MainProBar.MainProBarLocal.Value++;
            }
            else
            {
                PickBt3.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 255, 0, 0));
            }
        }

        private void PickBt4_Click(object sender, RoutedEventArgs e)
        {
            if (PickBt4.Content.ToString() == JsonWords.EWArray[currentRuWord])
            {
                positiveBtClick += 1;
                if (TrainerModel.timesAmount == positiveBtClick && TrainerModel.trainEnabled == true)
                {
                    positiveBtClick = 0;
                    Frame.Navigate(typeof(GreatJob));
                }
                currentRuWord = random.Next(0, JsonWords.RWArray.Length);
                SomeEnWord.Text = JsonWords.RWArray[currentRuWord];
                BgImg.Source = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{JsonWords.EWArray[currentRuWord]}.jpg"));
                GenerateNewWords();
                MainProBar.MainProBarLocal.Value++;
            }
            else
            {
                PickBt4.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 255, 0, 0));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            JsonWords.Init(); // инициализация словаря
            //this.NavigationCacheMode = NavigationCacheMode.Enabled; // кэш страницы вкл.
            currentRuWord = random.Next(0, JsonWords.RWArray.Length);
            SomeEnWord.Text = JsonWords.RWArray[currentRuWord];
            BgImg.Source = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{JsonWords.EWArray[currentRuWord]}.jpg"));

            GenerateNewWords(); // Создание правильного варианта ответа в одной из кнопок
            BgImg.Height = MainStack.Height;

        }
    }
}
