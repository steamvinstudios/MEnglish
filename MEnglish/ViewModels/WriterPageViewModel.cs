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
        private Words words = new Words();
        public Words Words
        {
            get => words;
            set => SetProperty(ref words, value);
        }
    }
}
