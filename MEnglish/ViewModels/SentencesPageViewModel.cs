using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class SentencesPageViewModel : BaseViewModel
    {
        public Sentences Sentences { get; set; } = new Sentences();
        public PickerTrainer PickerTrainer { get; set; } = new PickerTrainer();
    }
}
