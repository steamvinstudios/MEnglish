using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class GenPoint : Page
    {
        public ViewModels.MVVMTestPageViewModel ViewModel { get; set; } =
            new ViewModels.MVVMTestPageViewModel();
        public GenPoint() =>
            this.InitializeComponent();

        private void AboutPageButton_Click(object sender, RoutedEventArgs e) =>
            GenPointFrame.Navigate(typeof(AboutPage), null, new DrillInNavigationTransitionInfo());

        private void PickerPageButton_Click(object sender, RoutedEventArgs e) =>
            GenPointFrame.Navigate(typeof(PickFromFour), ViewModel.Words, new DrillInNavigationTransitionInfo());

        private void HomePageButton_Click(object sender, RoutedEventArgs e) =>
            GenPointFrame.Navigate(typeof(TrainerMode), null, new DrillInNavigationTransitionInfo());

        private void Page_Loaded(object sender, RoutedEventArgs e) =>
            GenPointFrame.Navigate(typeof(TrainerMode), null, new DrillInNavigationTransitionInfo());

        private void HideNavigationBarButton_Click(object sender, RoutedEventArgs e)
        {
            navigationBarStack.Visibility = Visibility.Collapsed;
            showNavigationBarButton.Visibility = Visibility.Visible;
        }

        private void ShowMavigationBarButton_Click(object sender, RoutedEventArgs e)
        {
            showNavigationBarButton.Visibility = Visibility.Collapsed;
            navigationBarStack.Visibility = Visibility.Visible;
        }

        private void WriterPageButton_Click(object sender, RoutedEventArgs e) =>
            GenPointFrame.Navigate(typeof(MainPage), ViewModel.Words, new DrillInNavigationTransitionInfo());

        private void ProfilePageButton_Click(object sender, RoutedEventArgs e) =>
            GenPointFrame.Navigate(typeof(Views.ProfilePage), null, new DrillInNavigationTransitionInfo());
    }
}
