using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace MEnglish.Models
{
    public class WordBuilder
    {
        private Word word;
        public WordBuilder() => word = new Word();
        public WordBuilder SetEnglishForm(string englishForm)
        {
            word.EnglishForm = englishForm;
            return this;
        }
        public WordBuilder SetRussianForm(string russianForm)
        {
            word.RussianForm = russianForm;
            return this;
        }
        public WordBuilder SetRating(int rating)
        {
            word.Rating = rating;
            return this;
        }
        public WordBuilder SetIsLearned(bool isLearned)
        {
            word.IsLearned = isLearned;
            return this;
        }
        public WordBuilder SetLastRepeat(DateTime lastRepeat)
        {
            word.LastRepeat = lastRepeat;
            return this;
        }
        public WordBuilder SetImage(string image)
        {
            word.Image = image;
            return this;
        }
        public static implicit operator Word(WordBuilder builder) => builder.word;
    }
}
