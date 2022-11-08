using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Words
    {
        public ObservableCollection<Word> All { get; set; } = new ObservableCollection<Word>
        {
            new Word
            {
                EnglishForms = new List<string> { "hello" },
                RussianForms = new List<string> { "привет" },
                Image = "/ArrayPics/hello.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "apple" },
                RussianForms = new List<string> { "яблоко" },
                Image = "/ArrayPics/apple.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "bye" },
                RussianForms = new List<string> { "пока" },
                Image = "/ArrayPics/bye.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "bridge" },
                RussianForms = new List<string> { "мост" },
                Image = "/ArrayPics/bridge.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "jungle" },
                RussianForms = new List<string> { "джунгли" },
                Image = "/ArrayPics/jungle.jpg"
            },
        };
    }
}
