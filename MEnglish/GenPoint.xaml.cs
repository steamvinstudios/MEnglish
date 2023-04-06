using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class GenPoint : Page
    {
        public GenPoint()
        {
            this.InitializeComponent();
            stackProBar.Children.Add(MainProBar.MainProBarLocal);
            
            //this.NavigationCacheMode = NavigationCacheMode.Enabled; // кэш страницы вкл.

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(Dictionary));
            CurrentPage.PageIs = "Dictionary";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(MainPage));
            CurrentPage.PageIs = "MainPage";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(AboutPage));
            CurrentPage.PageIs = "AboutPage";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(PickFromFour));
            CurrentPage.PageIs = "PickFromFour";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(TrainerMode));
            CurrentPage.PageIs = "TrainerMode";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(TrainerMode));
        }

        private void orientationSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (orientationSwitch.IsOn)
            {
                WowSt.Orientation = Orientation.Vertical;
                BtStack.Orientation = Orientation.Vertical;
                WowSt.HorizontalAlignment = HorizontalAlignment.Center;
                BtStack.HorizontalAlignment = HorizontalAlignment.Center;
            }
            else
            {
                WowSt.Orientation = Orientation.Vertical;
                BtStack.Orientation = Orientation.Vertical;
                WowSt.HorizontalAlignment = HorizontalAlignment.Center;
                BtStack.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
