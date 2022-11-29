using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class PickerPageViewModel : BaseViewModel
    {
        private PickerTrainer pickerTrainer = new PickerTrainer();
        public PickerTrainer PickerTrainer
        {
            get => pickerTrainer;
            set => SetProperty(ref pickerTrainer, value);
        }
    }
}
