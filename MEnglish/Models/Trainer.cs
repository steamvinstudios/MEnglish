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
        public bool IsNextTrainer { get; set; } = false;
        private int nextTrainerCounter = 0;
        public int NextTrainerCounter 
        {
            get => nextTrainerCounter; 
            set
            {
                SetProperty(ref nextTrainerCounter, value);
                if (nextTrainerCounter > 3)
                {
                    nextTrainerCounter = 0;
                    IsNextTrainer= true;
                }
            }
        }
        public int PositivePoints { get; set; } = 10;
        public int NegativePoints { get; set; } = 5;
        private AnswersResult answersResult = new AnswersResult();
        public AnswersResult AnswersResult
        {
            get => answersResult;
            set => SetProperty(ref answersResult, value);
        }
        private TrainerStopwatch trainerStopwatch = new TrainerStopwatch();
        public TrainerStopwatch TrainerStopwatch
        {
            get => trainerStopwatch;
            set => SetProperty(ref trainerStopwatch, value);
        }
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
