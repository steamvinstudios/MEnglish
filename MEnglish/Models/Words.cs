using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Words
    {
        ObservableCollection<Word> All = new ObservableCollection<Word>
        {
            new Word
            {
                EnglishForms = new List<string> { "Carrot" },
                RussianForms = new List<string> { "морковь", "морковка"  }
            }
        };
    }
}
