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
        public List<EnglishForm> EnglishForms { get; set; }
        public List<RussianForm> RussianForms { get; set; }
        public int Rating { get; set; }
        public bool IsLearned { get; set; }
        public DateTime LastRepeat { get; set; }
        public string Image { get; set; } = "/ArrayPics/hello.jpg";
        public string RatingFull() => $"Рейтинг: {Rating}";
        public string IdFull() => $"ID в базе: {Id}";
    }
}
