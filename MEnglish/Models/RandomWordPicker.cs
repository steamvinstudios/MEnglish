using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class RandomWordPicker : ObservableObject
    {
        private Word word;
        public Word Word
        {
            get => word;
            set => SetProperty(ref word, value);
        }
    }
}
