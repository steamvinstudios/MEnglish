using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Trainer : ObservableObject
    {
        public AnswersResult AnswersResult { get; set; }
        public TrainerStopwatch TrainerStopwatch { get; set; }
        private List<Word> words;
        public List<Word> Words
        {
            get => words;
            set => SetProperty(ref words, value);
        }
        public Trainer()
        {
            using (WordContext db = new WordContext())
            {
                words = db.Words.ToList();
            }
        }
    }
}
