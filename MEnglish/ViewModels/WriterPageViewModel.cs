using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class WriterPageViewModel : ObservableObject
    {
        public WriterTrainer WriterTrainer { get; set; } = new WriterTrainer();
        private Words words = new Words();
        public Words Words
        {
            get => words;
            set => SetProperty(ref words, value);
        }
    }
}
