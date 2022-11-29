using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MEnglish.Models
{
    public class PickerTrainer : Trainer
    {
        private bool wordProgressTeachingTipIsOpen = false;
        public bool WordProgressTeachingTipIsOpen
        {
            get => wordProgressTeachingTipIsOpen;
            set => SetProperty(ref wordProgressTeachingTipIsOpen, value);
        }
        public ObservableCollection<Word> FourRandomWords = new ObservableCollection<Word>();
        private Word randomWord = new Word();
        public Word RandomWord
        {
            get => randomWord;
            set => SetProperty(ref randomWord, value);
        }

        public PickerTrainer()
        {
            for (int i = 0; i < 4; i++)
                FourRandomWords.Add(Words[new Random().Next(Words.Count - 1)]);

            AddRandomWord();
        }

        private void AddFourRandomWords()
        {
            for (int i = 0; i < 4; i++)
                FourRandomWords[i] = Words[new Random().Next(Words.Count - 1)];
        }

        private void AddRandomWord()
        {
            RandomWord = FourRandomWords[new Random().Next(FourRandomWords.Count - 1)];
        }

        public async void CheckWords(object sender)
        {
            if ((sender as Button).Content.ToString().Equals(RandomWord.EnglishForm))
            {
                RandomWord.LastRepeat = DateTime.Now;

                using (WordContext db = new WordContext())
                {
                    RandomWord.Rating += 10;

                    if (RandomWord.Rating >= 100 && RandomWord.IsLearned == false)
                    {
                        RandomWord.IsLearned = true;
                        WordProgressTeachingTipIsOpen = true;
                        await Task.Delay(2000);
                        WordProgressTeachingTipIsOpen = false;
                        await Task.Delay(1000);
                    }

                    db.Words.Update(RandomWord);
                    db.SaveChanges();
                }

                AnswersResult.All++;
                AnswersResult.Correct++;

                using (WordContext db = new WordContext())
                {
                    Words = db.Words.ToList();
                }

                AddFourRandomWords();
                AddRandomWord();
            }
            else
            {
                var contentDialog = new ContentDialog
                {
                    Title = "Ошибка",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                RandomWord.LastRepeat = DateTime.Now;

                using (WordContext db = new WordContext())
                {
                    db.Words.Update(RandomWord);
                    db.SaveChanges();
                }

                AnswersResult.All++;
                AnswersResult.Mistakes++;
            }
        }
    }
}
