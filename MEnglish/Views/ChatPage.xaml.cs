using MEnglish.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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
using static System.Net.Mime.MediaTypeNames;

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

            Messages.Add(new Message { MsgAlignment = HorizontalAlignment.Left, MsgText = "Это тренажер Чат, который представляет собой мини-игру в слова. Ты пишешь любое слово на английском, а тебе чат-бот отвечает словом на последнюю буквы из твоего. И наоборот" });
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Messages.Add(new Message { MsgText = userMsg.Text, Color = new SolidColorBrush(Colors.DarkOrange) });

            List<Word> words = new List<Word>();

            char lastLetter = userMsg.Text[userMsg.Text.Length - 1];

            userMsg.Text = "";

            await Task.Delay(2000);

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
            });

            await Task.Delay(2000);

            Messages.Add(new Message
            {
                MsgAlignment = HorizontalAlignment.Left,
                Img = new BitmapImage(new Uri($"ms-appx:///ArrayPics/{randomWord.EnglishForm}.jpg"))
            });


        }

        private async void userMsg_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (!Regex.IsMatch(sender.Text, "^[a-zA-Z ]*$") && !String.IsNullOrWhiteSpace(userMsg.Text))
            {
                int pos = sender.SelectionStart - 1;
                if (pos >= 0) // добавить эту проверку
                {
                    sender.Text = sender.Text.Remove(pos, 1);
                    sender.SelectionStart = pos;

                    var contentDialog = new ContentDialog
                    {
                        Title = "Только английские слова",
                        Content = "Могут быть введены только английские буквы и слова",
                        CloseButtonText = "Закрыть"
                    };

                    var result = await contentDialog.ShowAsync();

                    userMsg.Text = "";
                }
            }
        }
    }

    public class Message
    {
        public HorizontalAlignment MsgAlignment { get; set; } = HorizontalAlignment.Right;
        public string MsgText { get; set; } = "";
        public DateTime MsgDateTime { get; set; } = DateTime.Now;
        public SolidColorBrush Color { get; set; } = new SolidColorBrush(Colors.DeepSkyBlue);
        public ImageSource Img = new BitmapImage(new Uri($"ms-appx:///"));
    }
}
