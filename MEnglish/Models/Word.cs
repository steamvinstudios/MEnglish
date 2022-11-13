using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Word
    {
        public int Id { get; set; }
        public List<EnglishForm> EnglishForms { get; set; } = new List<EnglishForm>();
        public List<RussianForm> RussianForms { get; set; } = new List<RussianForm>();
        public int Rating { get; set; }
        public bool IsLearned { get; set; }
        public DateTime LastRepeat { get; set; }
        public string Image { get; set; } = "/ArrayPics/hello.jpg";
    }
}
