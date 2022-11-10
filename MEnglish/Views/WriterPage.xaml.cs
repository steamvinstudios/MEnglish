using MEnglish.Models;
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
        public Words Words { get; set; }
        public Stopwatch Stopwatch { get; set; } = new Stopwatch();
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Words = (Words)e.Parameter;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CountTimeAsync();
        }

        private void NextTrainerButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PickFromFour), Words);
        }

        private async void CountTimeAsync()
        {
            Stopwatch.Start();
            while (true)
            {
                TimeAmountTextBlock.Text = Stopwatch.Elapsed.TotalSeconds.ToString();
                await Task.Delay(1000);
            }
        }

    }
}
