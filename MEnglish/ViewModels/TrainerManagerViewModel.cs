using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MEnglish.ViewModels
{
    public class TrainerManagerViewModel : BaseViewModel
    {
        private Frame currentPageFrame = new Frame();
        public Frame CurrentPageFrame
        {
            get => currentPageFrame;
            set => SetProperty(ref currentPageFrame, value);
        }
        public WriterPage WriterPage { get; set; } = new WriterPage();
        public PickerPage PickerPage { get; set; } = new PickerPage();
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
