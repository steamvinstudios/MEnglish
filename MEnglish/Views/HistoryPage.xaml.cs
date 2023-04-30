using MEnglish.Models;
using MEnglish.ViewModels;
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

namespace MEnglish.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class HistoryPage : Page
    {
        public List<History> Answers { get; set; } = new List<History>();
        private HistoryPageViewModel viewModel { get; set; } = new HistoryPageViewModel();
        public HistoryPage()
        {
            this.InitializeComponent();

            using (var db = new HistoryContext())
            {
                Answers = db.Histories.ToList();
            }
        }
    }
}
