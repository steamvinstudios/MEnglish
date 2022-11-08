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
            new Word
            {
                EnglishForms = new List<string> { "forest" },
                RussianForms = new List<string> { "лес" },
                Image = "/ArrayPics/forest.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "animal" },
                RussianForms = new List<string> { "животное" },
                Image = "/ArrayPics/animal.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "area" },
                RussianForms = new List<string> { "зона" },
                Image = "/ArrayPics/area.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "book" },
                RussianForms = new List<string> { "книга" },
                Image = "/ArrayPics/book.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "camera" },
                RussianForms = new List<string> { "камера" },
                Image = "/ArrayPics/camera.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "coffee" },
                RussianForms = new List<string> { "кофе" },
                Image = "/ArrayPics/coffee.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "end" },
                RussianForms = new List<string> { "конец" },
                Image = "/ArrayPics/end.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "eye" },
                RussianForms = new List<string> { "глаз" },
                Image = "/ArrayPics/eye.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "farm" },
                RussianForms = new List<string> { "ферма" },
                Image = "/ArrayPics/farm.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "feet" },
                RussianForms = new List<string> { "ноги" },
                Image = "/ArrayPics/feet.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "fire" },
                RussianForms = new List<string> { "огонь" },
                Image = "/ArrayPics/fire.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "food" },
                RussianForms = new List<string> { "еда" },
                Image = "/ArrayPics/food.jpg"
            },
        };
    }
}
