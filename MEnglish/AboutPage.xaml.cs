using Newtonsoft.Json;
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
            //this.NavigationCacheMode = NavigationCacheMode.Enabled; // кэш страницы вкл.
            
        }

        async void VKGroupTextAnim()
        {
            Random random = new Random();
            byte r = 0;
            byte g = 0;
            byte b = 0;

            while (true)
            {
                r = Convert.ToByte(random.Next(0, 255));
                g = Convert.ToByte(random.Next(0, 255));
                b = Convert.ToByte(random.Next(0, 255));

                VKGroupText.Foreground = new SolidColorBrush(Color.FromArgb(255, r, g, b));

                await Task.Delay(500);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            VKGroupTextAnim();
        }
    }
}
