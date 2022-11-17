using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class AnswersResult : ObservableObject
    {
        private int all;
        public int All
        {
            get => all;
            set => SetProperty(ref all, value);
        }
        private int correct;
        public int Correct
        {
            get => correct;
            set => SetProperty(ref correct, value);
        }
        private int mistakes;
        public int Mistakes
        {
            get => all;
            set => SetProperty(ref mistakes, value);
        }
    }
}
