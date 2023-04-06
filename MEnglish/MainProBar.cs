using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish
{
    public static class MainProBar
    {
        public static int Value { get; set; } = 0;
        public static int Max { get; set; } = 0;
        public static ProgressBar MainProBarLocal { get; set; } = new ProgressBar();
    }
}
