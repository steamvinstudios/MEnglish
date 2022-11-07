using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Word
    {
        public List<string> EnglishForms { get; set; } = new List<string>();
        public List<string> RussianForms { get; set; } = new List<string>();
        public int Rating { get; set; } = 0;
        public bool IsLearned { get; set; } = false;
        public DateTime LastRepeat { get; set; } = DateTime.Now;
    }
}
