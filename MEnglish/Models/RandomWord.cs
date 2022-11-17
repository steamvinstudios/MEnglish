using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class RandomWord : ObservableObject
    {
        private List<Word> words;
        private Word word;
        public Word Word
        {
            get => word;
            set => SetProperty(ref word, value);
        }
        public RandomWord()
        {
            using (WordContext db = new WordContext())
            {
                words = db.Words.ToList();
            }

            word = words[new Random().Next(words.Count - 1)];
        }
    }
}
