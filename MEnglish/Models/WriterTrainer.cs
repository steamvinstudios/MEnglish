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
        public Word RandomWord { get; set; }
        public WriterTrainer()
        {
            using (WordContext db = new WordContext())
            {
                Words = db.Words.ToList();
            }

            RandomWord = Words[new Random().Next(Words.Count - 1)];
        }
    }
}
