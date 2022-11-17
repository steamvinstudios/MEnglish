using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class FourRandomWords : ObservableObject
    {
        public ObservableCollection<Word> Words { get; set; }
        private List<Word> words;
        public FourRandomWords()
        {
            using (WordContext db = new WordContext())
            {
                words = db.Words.ToList();
            }

            Words = new ObservableCollection<Word>();

            for (int i = 0; i < 4; i++)
            {
                Words.Add(words[new Random().Next(words.Count - 1)]);
            }
        }

        public void ShakeWords()
        {
            for (int i = 0; i < 4; i++)
            {
                Words.Add(words[new Random().Next(words.Count - 1)]);
            }
        }
    }
}
