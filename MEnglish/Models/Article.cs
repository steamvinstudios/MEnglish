using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Article
    {
        public string Title { get; set; } = "No data";
        public string Body { get; set; } = "No data";
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
