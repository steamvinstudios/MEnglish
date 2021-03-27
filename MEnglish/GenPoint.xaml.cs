using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class GenPoint : Page
    {
        public VerticalAlignment LocalVertAlign { get; set; } = GlobalUISettings.VerticalPO;
        public ViewModelUI Vm { get; set; } = new ViewModelUI();
        public GenPoint()
        {
            this.InitializeComponent();

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
            stackProBar.Children.Add(MainProBar.MainProBarLocal);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GenPointFrame.Navigate(typeof(SettingsView));
        }
    }
}
