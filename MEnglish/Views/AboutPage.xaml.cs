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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RectangleAnimation();
        }

        private async void RectangleAnimation()
        {
            while (true)
            {
                await Task.Delay(1000);
                rectangle.Rotation = new Random().Next(360);
                rectangle1.Rotation = new Random().Next(360);
                rectangle2.Rotation = new Random().Next(360);
                rectangle3.Rotation = new Random().Next(360);
                rectangle4.Rotation = new Random().Next(360);
                rectangle5.Rotation = new Random().Next(360);
            }
        }
    }
}
