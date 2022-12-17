using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class TrainerManagerViewModel : BaseViewModel
    {
        public TrainerManager TrainerManager { get; set; }
        public TrainerManagerViewModel()
        {
            TrainerManager = new TrainerManager(
                new List<Trainer>
                {
                    new WriterTrainer(),
                    new PickerTrainer()
                }
                );
        }
    }
}
