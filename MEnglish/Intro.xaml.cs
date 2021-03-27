using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Intro : Page
    {
        public Intro()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            IntroScale.ScaleX = 0.5;
            IntroScale.ScaleY = 0.5;
            await Task.Delay(1000);
            IntroScale2.ScaleX = 0.5;
            IntroScale2.ScaleY = 0.5;
            await Task.Delay(3000);
            Frame.Navigate(typeof(GenPoint));
        }
    }
}
