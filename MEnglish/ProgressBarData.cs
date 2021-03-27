using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish
{
    class ProgressBarData
    {
        public static int PBValue { get; set; }
        public static int PBHeight { get; set; }
        public static int PBWidth { get; set; }
        public static async void PBDataInit()
        {
            PBHeight = 20;
            PBWidth = 200;
            while(PBValue < 100)
            {
                PBValue += 2;
                await Task.Delay(500);
            }
        }
    }
}
