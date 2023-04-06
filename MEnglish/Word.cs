using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace MEnglish
{
    public class Word
    {
        public string OriginalWord { get; set; }
        public string WordTranslation { get; set; }
        public bool IsLearned { get; set; } = false;
        public BitmapImage WordPic { get; set; } = new BitmapImage();
    }
}
    