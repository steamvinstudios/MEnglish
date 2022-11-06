using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class FourPics : Page
    {
        bool btSelected = false;
        bool img1Selected = false;
        bool img2Selected = false;
        bool img3Selected = false;
        bool img4Selected = false;
        public FourPics()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled; // кэш страницы вкл.
        }

        private void EnWord_Click(object sender, RoutedEventArgs e)
        {
            btSelected = !btSelected;
            if (btSelected == true)
            {
                EnWord.FontSize = 32;
            } else
            {
                EnWord.FontSize = 24;
            }
        }

        private void Img1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            img1Selected = !img1Selected;
            if (img1Selected == true)
            {
                Img1.Opacity = 0.5;
            } else
            {
                Img1.Opacity = 1.0;
            }

            if (img1Selected == btSelected)
            {
                EnWord.Content = "Правильно!";
            } else
            {
                EnWord.Content = "Sample Text";
            }
        }

        private void Img2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            img2Selected = !img2Selected;
            if (img2Selected == true)
            {
                Img2.Opacity = 0.5;
            }
            else
            {
                Img2.Opacity = 1.0;
            }

            if (img2Selected == btSelected)
            {
                EnWord.Content = "Неверно!";
            }
            else
            {
                EnWord.Content = "Sample Text";
            }
        }

        private void Img3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            img3Selected = !img3Selected;
            if (img3Selected == true)
            {
                Img3.Opacity = 0.5;
            }
            else
            {
                Img3.Opacity = 1.0;
            }

            if (img3Selected == btSelected)
            {
                EnWord.Content = "Неверно!";
            }
            else
            {
                EnWord.Content = "Sample Text";
            }
        }

        private void Img4_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            img4Selected = !img4Selected;
            if (img4Selected == true)
            {
                Img4.Opacity = 0.5;
            }
            else
            {
                Img4.Opacity = 1.0;
            }

            if (img4Selected == btSelected)
            {
                EnWord.Content = "Неверно!";
            }
            else
            {
                EnWord.Content = "Sample Text";
            }
        }
    }
}
