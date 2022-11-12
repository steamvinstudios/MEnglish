using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Word
    {
        public int WordId { get; set; }

        // Not Working (List/Array) with SQL (SQLite)
        //public List<string> EnglishForms { get; set; } = new List<string>();
        //public List<string> RussianForms { get; set; } = new List<string>();
        //public EnglishForms EnglishForms { get; set; } = new EnglishForms();
        //public RussianForms RussianForms { get; set; } = new RussianForms();
        // Figure out it

        public string EnglishForm { get; set; } = string.Empty;
        public string RussianForm { get; set; } = string.Empty;
        public int Rating { get; set; } = new Random().Next(100);
        public bool IsLearned { get; set; } = false;
        public DateTime LastRepeat { get; set; } = DateTime.Now;
        public string Image { get; set; } = "/ArrayPics/hello.jpg";
    }
}
