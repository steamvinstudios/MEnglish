using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Sentences
    {
        public ObservableCollection<Sentence> Collection { get; set; } = new ObservableCollection<Sentence>
        {
            new Sentence
            {
                English = "i love you",
                Russian = "я люблю тебя"
            },
            new Sentence
            {
                English = "let's go",
                Russian = "пошли"
            },
            new Sentence
            {
                English = "i want to drink",
                Russian = "я хочу пить"
            },
            new Sentence
            {
                English = "what's new?",
                Russian = "что нового?"
            },
            new Sentence
            {
                English = "how are things?",
                Russian = "как дела?"
            },
            new Sentence
            {
                English = "how's life?",
                Russian = "как жизнь?"
            },
            new Sentence
            {
                English = "how was your weekend?",
                Russian = "как прошли выходные?"
            },
            new Sentence
            {
                English = "i really appreciate it!",
                Russian = "я очень благодарен"
            },
            new Sentence
            {
                English = "i can’t help you there",
                Russian = "не могу помочь"
            },
        };
    }
}
