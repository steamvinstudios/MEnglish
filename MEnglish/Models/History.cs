using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class History
    {
        public int Id { get; set; }
        public string TrainerInfo { get; set; } = "Uknown Trainer";
        public DateTime Date { get; set; } = DateTime.Now;
        [ForeignKey("AnswersResultId")]
        public AnswersResult Result { get; set; } = new AnswersResult();
        public string Correct { get; set; } = "Default";
        public string All { get; set; } = "Default";
        public string Mistakes { get; set; } = "Default";

    }
}
