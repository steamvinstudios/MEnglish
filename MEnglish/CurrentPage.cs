using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace MEnglish
{
    public class CurrentPage
    {
        public static string PageIs { get; set; }
        public static async void Init()
        {
            if (PageIs == "AboutPage")
            {
                await Task.Delay(5000);
                // Construct the content
                var content = new ToastContentBuilder()
                    .AddToastActivationInfo("sample text", ToastActivationType.Foreground)
                    .AddText("Это страница о приложении")
                    .AddText("Здесь основаная информация и полезные ссылки")
                    .GetToastContent();

                // Create the notification
                var notif = new ToastNotification(content.GetXml());

                // And show it!
                ToastNotificationManager.CreateToastNotifier().Show(notif);
            }
        }
    }
}
