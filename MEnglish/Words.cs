using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace MEnglish
{
    public class Words : INotifyPropertyChanged
    {
        public List<Word> WordsArray { get; set; } = new List<Word>()
        {
            new Word()
            {
                OriginalWord = "ancestor",
                WordTranslation = "предок"
            },
            new Word()
            {
                OriginalWord = "establish",
                WordTranslation = "устанавливать"
            },
            new Word()
            {
                OriginalWord = "persistent",
                WordTranslation = "постоянный"
            },
            new Word()
            {
                OriginalWord = "go beyond",
                WordTranslation = "выходить за грань"
            },
            new Word()
            {
                OriginalWord = "sealed",
                WordTranslation = "запечатанный"
            },
            new Word()
            {
                OriginalWord = "immediately",
                WordTranslation = "немедленно"
            },
            new Word()
            {
                OriginalWord = "clarify",
                WordTranslation = "прояснять"
            },
            new Word()
            {
                OriginalWord = "impact",
                WordTranslation = "влияние"
            },
            new Word()
            {
                OriginalWord = "offensive",
                WordTranslation = "наступление"
            },
            new Word()
            {
                OriginalWord = "tedious",
                WordTranslation = "утомительный"
            },
            /*
            explicit - явный
            implicit - неявный
            interconnected - взаимосвязанный
            fluffy - пушистый
            proposed - предложенный
            addictive game - захватывающая игра
            occured - произошло
            invoke - вызывать
            over time - со временем
            consider - рассмотреть возможность
             */
        };
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
