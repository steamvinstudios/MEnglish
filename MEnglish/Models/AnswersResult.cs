﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class AnswersResult : ObservableObject
    {
        public int Id { get; set; }
        public History History { get; set; }
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
            get => mistakes;
            set => SetProperty(ref mistakes, value);
        }

        public void IncreaseAll() => All++;
        public void IncreaseCorrect() => Correct++;
        public void IncreaseMistakes() => Mistakes++;
    }
}
