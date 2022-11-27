using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class WriterPageViewModel : BaseViewModel
    {
        private WriterTrainer writerTrainer = new WriterTrainer();
        public WriterTrainer WriterTrainer
        {
            get => writerTrainer;
            set => SetProperty(ref writerTrainer, value);
        }
    }
}
