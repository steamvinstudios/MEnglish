using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class TrainerManager
    {
        public List<Trainer> Trainers { get; set; }
        public TrainerManager(List<Trainer> trainers)
        {
            Trainers = trainers;
        }
    }
}
