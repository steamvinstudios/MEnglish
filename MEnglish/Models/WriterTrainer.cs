using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MEnglish.Models
{
    public class WriterTrainer : Trainer
    {
        private bool wordInfoTeachingTipIsOpen = false;
        public bool WordInfoTeachingTipIsOpen
        {
            get => wordInfoTeachingTipIsOpen;
            set => SetProperty(ref wordInfoTeachingTipIsOpen, value);
        }
        private bool wordProgressTeachingTipIsOpen = false;
        public bool WordProgressTeachingTipIsOpen
        {
            get => wordProgressTeachingTipIsOpen;
            set => SetProperty(ref wordProgressTeachingTipIsOpen, value);
        }
        private Word randomWord = new Word();
        public Word RandomWord
        {
            get => randomWord;
            set => SetProperty(ref randomWord, value);
        }
        private string answerTextBoxText = "";
        public string AnswerTextBoxText
        {
            get => answerTextBoxText;
            set => SetProperty(ref answerTextBoxText, value);
        }
        public WriterTrainer()
        {
            RandomWord = Words[new Random().Next(Words.Count - 1)];
        }
        public async void CheckAnswerAsync()
        {
            if (AnswerTextBoxText.ToLower().Equals(RandomWord.RussianForm))
            {
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

                    db.Update(RandomWord);
                    db.SaveChanges();
                }

                RandomWord = Words[new Random().Next(Words.Count - 1)];

                AnswerTextBoxText = "";

                AnswersResult.IncreaseAll();
                AnswersResult.IncreaseCorrect();

                WordInfoTeachingTipIsOpen = false;
            }
            else
            {
                using (WordContext db = new WordContext())
                {
                    db.Update(RandomWord);
                    db.SaveChanges();
                }

                var contentDialog = new ContentDialog
                {
                    Title = "Ошибка",
                    CloseButtonText = "Закрыть"
                };

                var result = await contentDialog.ShowAsync();

                AnswersResult.IncreaseAll();
                AnswersResult.IncreaseMistakes();

                WordInfoTeachingTipIsOpen = true;
            }
        }
    }
}
