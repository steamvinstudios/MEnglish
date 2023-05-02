using MEnglish.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ChatPage : Page
    {
        public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();
        public List<Word> Responses { get; set; } = new List<Word>();
        public List<string> ResponseComments { get; set; } = new List<string>
        {
            "Вот мой ответ:",
            "Хм, тогда так:",
            "Мой ход:",
            "Держи:",
        };

        public ChatPage()
        {
            this.InitializeComponent();

            using (var db = new WordContext())
            {
                Responses = db.Words.ToList();
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Messages.Add(new Message { MsgText = userMsg.Text, Color = new SolidColorBrush(Colors.DarkOrange) });

            await Task.Delay(1000);

            List<Word> words = new List<Word>();

            char lastLetter = userMsg.Text[userMsg.Text.Length - 1];

            for (int i = 0; i < Responses.Count; i++)
            {
                // Проверка, начинается ли слово с этой буквы
                if (Responses[i].EnglishForm.StartsWith(lastLetter))
                {
                    // Добавление слова в список
                    words.Add(Responses[i]);
                }
            }

            var randomWord = words[new Random().Next(words.Count - 1)];

            Messages.Add(new Message
            {
                MsgAlignment = HorizontalAlignment.Left,
                MsgText = $"{ResponseComments[new Random().Next(ResponseComments.Count)]} {randomWord.EnglishForm}. Кстати, слово переводится как {randomWord.RussianForm}",
                Img = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{randomWord.EnglishForm}.jpg"))
            });
        }
    }

    public class Message
    {
        public HorizontalAlignment MsgAlignment { get; set; } = HorizontalAlignment.Right;
        public string MsgText { get; set; } = "ответ таков";
        public DateTime MsgDateTime { get; set; } = DateTime.Now;
        public SolidColorBrush Color { get; set; } = new SolidColorBrush(Colors.DeepSkyBlue);
        public ImageSource Img = new BitmapImage(new Uri($"ms-appx:///"));
    }
}
