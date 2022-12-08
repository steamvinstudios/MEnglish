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
            // сортировка коллекции слов по рейтингу
            Words = Words.OrderBy(w => w.Rating).ToList();

            // добавляем 4 наименее изученных слова
            for (int i = 0; i < 4; i++)
                FourRandomWords.Add(Words[i]);

            AddRandomWord();
        }

        private void AddFourRandomWords()
        {
            // сортировка коллекции слов по рейтингу
            Words = Words.OrderBy(w => w.Rating).ToList();

            // обновляем 4 наименее изученных слова
            for (int i = 0; i < 4; i++)
                FourRandomWords[i] = Words[i];
        }

        private void AddRandomWord() =>
            RandomWord = FourRandomWords[new Random().Next(FourRandomWords.Count - 1)];

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

                AnswersResult.IncreaseAll();
                AnswersResult.IncreaseCorrect();

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

                AnswersResult.IncreaseAll();
                AnswersResult.IncreaseMistakes();
            }
        }
    }
}
