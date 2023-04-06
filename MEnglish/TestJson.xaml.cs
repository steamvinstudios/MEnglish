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
using Newtonsoft.Json;
using Windows.Storage;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class TestJson : Page
    {
        TestWord testWord = new TestWord();
        public TestJson()
        {
            this.InitializeComponent();
        }

        private async void TestPage_Loaded(object sender, RoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile file = await storageFolder.CreateFileAsync("TestJsonFile.json",
                    CreationCollisionOption.OpenIfExists);

            await FileIO.WriteTextAsync(file, JsonConvert.SerializeObject(testWord));

            file = await storageFolder.GetFileAsync("TestJsonFile.json");
            string text = await FileIO.ReadTextAsync(file);
            testText.Text = JsonConvert.DeserializeObject<TestWord>(text).Origin;
        }
    }
    public class TestWord
    {
        public string Origin { get; set; } = "sample";
        public string Translated { get; set; } = "что-то русское";
    }
}
