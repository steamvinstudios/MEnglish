﻿using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class GreatJob : Page
    {
        public GreatJob()
        {
            this.InitializeComponent();
            // здесь кэш не нужен, иначе не будет возвращать на страницу тренировки
            GoToTheNext();
        }

        async void GoToTheNext()
        {
            TrainerModel.timesAmount = 0;
            await Task.Delay(2000);
            Frame.Navigate(typeof(TrainerMode));
        }
    }
}
