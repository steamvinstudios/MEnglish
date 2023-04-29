using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class VerberPageViewModel : BaseViewModel
    {
        public Verbs Verbs { get; set; } = new Verbs();
        public PickerTrainer PickerTrainer { get; set; } = new PickerTrainer();
    }
}
