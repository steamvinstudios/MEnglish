using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
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
    public sealed partial class MainPage : Page
    {
        MediaPlayer player;

        Random random = new Random();
        int currentEngWord = 0;
        int ratingBar = 0;
        int badRatingBar = 0;
        int maxValue = 0;
        int t = 0;
        int positiveBtClick = 0;

        // подсказка при наведении на англ. слово
        TeachingTip teachingTip = new TeachingTip();
        // всплывающая панель подсказок
        StackPanel teachingStack = new StackPanel();
        //TextBlock headerWord = new TextBlock();
        TextBlock bigWord = new TextBlock();

        BitmapImage bitmapImage = new BitmapImage();
        public MainPage()
        {
            this.InitializeComponent();
            
            //this.NavigationCacheMode = NavigationCacheMode.Enabled; // кэш страницы вкл.

        }

        async void ApplicationTimer()
        {
            while(true)
            {
                await Task.Delay(1000);
                t += 1;
                AppTimer.Text = t.ToString();
            }
        }

        async void ShowOpacityButton()
        {
            for(; ShowResultBut.Opacity <= 1.0; ShowResultBut.Opacity += 0.05)
            {
                await Task.Delay(10);
            }
            for (; ShowResultBut.Opacity >= 0.0; ShowResultBut.Opacity -= 0.05)
            {
                await Task.Delay(10);
            }
        }

        async void ShowOpacityPic()
        {
            for (; WordPic.Opacity <= 1.0; WordPic.Opacity += 0.05)
            {
                await Task.Delay(10);
            }
        }

        async void ShowOpacityEngWord()
        {
            for (; EngWord.Opacity <= 1.0; EngWord.Opacity += 0.05)
            {
                await Task.Delay(10);
            }
        }

        async void CheckLogic()
        {
            maxValue += 1;
            BadGoodBar.Maximum = maxValue;
            if (RuWord.Text == JsonWords.RWArray[currentEngWord])
            {
                IfTrue();
                positiveBtClick += 1;
                if (TrainerModel.timesAmount == positiveBtClick && TrainerModel.trainEnabled == true)
                {
                    positiveBtClick = 0;
                    Frame.Navigate(typeof(PickFromFour));
                }
                WordPic.Opacity = 0.0;
                EngWord.Opacity = 0.0;
                Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
                Windows.Storage.StorageFile file = await folder.GetFileAsync("Windows Balloon.wav");
                player.AutoPlay = false;
                player.Source = MediaSource.CreateFromStorageFile(file);
                player.Play();
                ShowOpacityButton();
                ElementSoundPlayer.Play(ElementSoundKind.MoveNext);
                currentEngWord = random.Next(0, JsonWords.EWArray.Length);
                EngWord.Text = JsonWords.EWArray[currentEngWord];
                bitmapImage.UriSource = new Uri(WordPic.BaseUri, $"ArrayPics/{JsonWords.EWArray[currentEngWord]}.jpg");
                WordPic.Source = bitmapImage;
                ShowOpacityPic();
                ShowOpacityEngWord();
                RuWord.Text = "";
                ratingBar += 1;
                //
                MainProBar.MainProBarLocal.Value++;
                BadGoodBar.Value = ratingBar;
            }
            else
            {
                IfFalse();
                badRatingBar += 1;
            }
            MaxOfBar.Text = $"{Convert.ToString(BadGoodBar.Maximum)}";
            TrueBar.Text = $"{Convert.ToString(BadGoodBar.Value)}";
            FalseBar.Text = $"{badRatingBar}";
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            CheckLogic();
        }

        private void RuWord_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                CheckLogic();
            }
        }

        private void EngWord_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            IfFalse();
        }

        private void EngWord_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            IfTrue();
        }

        void IfFalse()
        {
            teachingTip.Target = EngWord;
            teachingTip.Content = teachingStack;

            //headerWord.FontSize = 36;
            //headerWord.Text = "Перевод:";

            teachingTip.Title = "Подсказка:";
            teachingTip.Subtitle = JsonWords.EWArray[currentEngWord];

            bigWord.FontSize = 20;
            bigWord.Padding = new Thickness(0);
            bigWord.Margin = new Thickness(0);
            bigWord.TextWrapping = TextWrapping.Wrap;
            bigWord.Text = JsonWords.RWArray[currentEngWord];

            teachingTip.IsOpen = true;
        }

        void IfTrue()
        {
            teachingTip.IsOpen = false;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            JsonWords.Init(); // инициализация словаря

            // наполняем вспл. подсказку
            teachingStack.Children.Add(bigWord);

            // добавление подсказки на англ. слово
            CenterStack.Children.Add(teachingTip);

            player = new MediaPlayer();

            // Первоначальная инициализация слова
            currentEngWord = random.Next(0, JsonWords.EWArray.Length);
            EngWord.Text = JsonWords.EWArray[currentEngWord];

            // Путь к картинке и инициализация
            bitmapImage.UriSource = new Uri(WordPic.BaseUri, $"ArrayPics/{JsonWords.EWArray[currentEngWord]}.jpg");
            WordPic.Source = bitmapImage;

            // Таймер
            ApplicationTimer();
            var myWriter = sender as MainPage;
        }
    }
}
