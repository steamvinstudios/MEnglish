using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace MEnglish
{
    public class SettingsViewModel
    {
        public HorizontalAlignment HorAlign { get; set; } = HorizontalAlignment.Center;
        public VerticalAlignment VerAlign { get; set; } = VerticalAlignment.Center;
        public List<string> myList { get; set; } = new List<string>()
        {
            "Верх",
            "Низ",
            "Право",
            "Лево",
        };
    }
}
