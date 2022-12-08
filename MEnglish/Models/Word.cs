using CommunityToolkit.Mvvm.ComponentModel;
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
        public string EnglishForm { get; set; } = "No Data";
        public string RussianForm { get; set; } = "No Data";
        public int Rating { get; set; }
        public bool IsLearned { get; set; } = false;
        public DateTime LastRepeat { get; set; } = DateTime.Now;
        public string Image { get; set; } = "/ArrayPics/withoutimg.png";
        public string RatingFull() => $"Рейтинг: {Rating}";
        public string IdFull() => $"ID в базе: {Id}";
        public static WordBuilder CreateBuilder() => new WordBuilder();
    }
}
