using Microsoft.Toolkit.Uwp.UI.Animations.Expressions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class SettingsView : Page
    {
        public SettingsViewModel VM { get; set; } = new SettingsViewModel();
        private double shareValue = 0.0;
        public bool BgFill { get; set; } = true;

        public double ShareValue 
        {
            get => shareValue;
            set 
            {
                shareValue = value;
                TextValue.Text = value.ToString();
                bgAcr.TintOpacity = value;
                bgAcr.TintLuminosityOpacity = value;
            }
        }
        public SettingsView()
        {
            this.InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            GoSsAnim();
        }

        private async void GoSsAnim()
        {
            while (true)
            {
                await Task.Delay(10);
                //ssBt.RotationTransition.Duration = new TimeSpan(1000);
            }
        }

        private void clrPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            bgAcr.TintColor = sender.Color;
            GlobalUISettings.BgColor = new SolidColorBrush(sender.Color);
            GlobalUISettings.BgAcr.TintColor = sender.Color;
        }

        private async void mySetView_Loaded(object sender, RoutedEventArgs e)
        {
            mySetView.Background = GlobalUISettings.BgAcr;
            /*//RotationX = "-35" RotationY = "-35" RotationZ = "15"
            while (rotPane.RotationX != 0)
            {
                await Task.Delay(4);
                rotPane.RotationX += 0.2;
                rotPane.RotationY += 0.2;
                if (rotPane.RotationZ != 0)
                {
                    rotPane.RotationZ -= 0.2;
                }
            }*/
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (BgFill)
            {
                mySetView.Background = GlobalUISettings.BgColor;
            }
            else
            {
                mySetView.Background = bgAcr;
            }
            BgFill = !BgFill;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            //ViewModelUI.PanelOrientation = Orientation.Vertical;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            //ViewModelUI.PanelOrientation = Orientation.Vertical;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            //ViewModelUI.PanelOrientation = Orientation.Horizontal;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            //ViewModelUI.PanelOrientation = Orientation.Horizontal;
        }

        private void ColorPicker_ColorChanged(Microsoft.UI.Xaml.Controls.ColorPicker sender, Microsoft.UI.Xaml.Controls.ColorChangedEventArgs args)
        {
            bgAcr.TintColor = sender.Color;
            GlobalUISettings.BgColor = new SolidColorBrush(sender.Color);
            GlobalUISettings.BgAcr.TintColor = sender.Color;
        }

        private async void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var workEl = sender as ComboBox;
            if (workEl.SelectedItem.ToString() == "Верх")
            {
                GlobalUISettings.VerticalPO = VerticalAlignment.Top;
                GlobalUISettings.OrientationPO = Orientation.Vertical;
                GlobalUISettings.HorizontalPO = HorizontalAlignment.Right;
            }
            else if (workEl.SelectedItem.ToString() == "Низ")
            {
                GlobalUISettings.VerticalPO = VerticalAlignment.Bottom;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalUISettings.OrientationPO = Orientation.Vertical;
        }

        private void Slider_ValueChanged_1(object sender, RangeBaseValueChangedEventArgs e)
        {
            var slider = sender as Slider;
            GlobalUISettings.BgAcr.TintLuminosityOpacity = slider.Value;
            GlobalUISettings.BgAcr.TintOpacity = slider.Value;
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            var from = new MailAddress("steamvinstudios@outlook.com", "Vin");
            var to = new MailAddress("steamvinstudios@outlook.com");
            var msg = new MailMessage(from, to);
            msg.Subject = "из приложения";
            msg.Body = personEmail.Text;
            msg.IsBodyHtml = true;
            var smtp = new SmtpClient("smtp.outlook.com", 587);
            smtp.Credentials = new NetworkCredential("steamvinstudios@outlook.com", "Zoom1997");
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }*/
    }
}
