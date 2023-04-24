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
            }
        };
    }
}
