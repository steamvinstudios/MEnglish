using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MEnglish
{
    public class GlobalUISettings
    {
        // настройки панели навигации
        public static HorizontalAlignment HorizontalPO { get; set; } = HorizontalAlignment.Center;
        public static VerticalAlignment VerticalPO { get; set; } = VerticalAlignment.Bottom;
        public static Orientation OrientationPO { get; set; } = Orientation.Horizontal;
        public static SolidColorBrush BgColor { get; set; } = new SolidColorBrush(Colors.Orange);
        // настройки панели навигации
        public static AcrylicBrush BgAcr { get; set; } = new AcrylicBrush()
        {
            BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
            TintColor = Colors.White,
            TintLuminosityOpacity = 0.2,
            TintOpacity = 0.2,
            Opacity = 1.0
        };
        public GlobalUISettings()
        {
            BgColor = new SolidColorBrush(Color.FromArgb(255, 70, 150, 190));
        }
    }
}
