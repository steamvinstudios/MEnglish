using MEnglish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Notifications;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MEnglish
{
    /// <summary>
    /// Обеспечивает зависящее от конкретного приложения поведение, дополняющее класс Application по умолчанию.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Инициализирует одноэлементный объект приложения. Это первая выполняемая строка разрабатываемого
        /// кода, поэтому она является логическим эквивалентом main() или WinMain().
        /// </summary>
        Words words = new Words();
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            using (var db = new WordContext())
            {
                db.Database.Migrate();

                // добавление новых слов в бд, которые докидываются с обновами
                var dbWords = db.Words.ToList();
                var exceptedWords = new List<Word>();

                // добавление слов, если не существуют в бд
                exceptedWords = words.All.Where(x => !dbWords.Any(y => y.EnglishForm == x.EnglishForm)).ToList();

                foreach (var word in exceptedWords)
                {
                    db.Words.Update(word);
                }

                db.SaveChanges();
            }

            RunNotificationService();
        }

        void RunNotificationService()
        {
            //.AddArgument("action", "openApp"))
            var toastContent = new ToastContentBuilder()
                    .AddText("Пора повторить и изучить новые слова")
                    .AddText("Откройте приложение и начните упражнение")
                    .AddButton(new ToastButton()
                    .SetContent("Открыть"))
                    .AddArgument("action", "openApp")
                    .GetToastContent();

            // Get the toast notifier
            var notificationManager = ToastNotificationManager.CreateToastNotifier();

            // получить все уведомления
            var scheduledNotifications = notificationManager.GetScheduledToastNotifications();

            // зачистка уведомлений при старте
            foreach (var notification in scheduledNotifications)
            {
                notificationManager.RemoveFromSchedule(notification);
            }

            for (int i = 1; i < 49; i++)
            {
                // Create a scheduled notification to be displayed in one hour
                var scheduledNotif = new ScheduledToastNotification(toastContent.GetXml(), DateTimeOffset.Now.AddHours(1 * i))
                {
                    // Assign a unique ID to the notification
                    Id = "HourlyReminder"
                };

                // Add the scheduled notification to the notifier
                notificationManager.AddToSchedule(scheduledNotif);
            }
        }

        /// <summary>
        /// Вызывается при обычном запуске приложения пользователем. Будут использоваться другие точки входа,
        /// например, если приложение запускается для открытия конкретного файла.
        /// </summary>
        /// <param name="e">Сведения о запросе и обработке запуска.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            // Не повторяйте инициализацию приложения, если в окне уже имеется содержимое,
            // только обеспечьте активность окна
            if (rootFrame == null)
            {
                // Создание фрейма, который станет контекстом навигации, и переход к первой странице
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Загрузить состояние из ранее приостановленного приложения
                }

                // Размещение фрейма в текущем окне
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // Если стек навигации не восстанавливается для перехода к первой странице,
                    // настройка новой страницы путем передачи необходимой информации в качестве параметра
                    // навигации
                    rootFrame.Navigate(typeof(NavigationBarPage), e.Arguments);
                }
                // Обеспечение активности текущего окна
                Window.Current.Activate();
                // Extend acrylic
                ExtendAcrylicIntoTitleBar(); // ПРОЗРАЧНЫЙ ВЕРХНИЙ БАР
            }
        }

        protected override void OnActivated(IActivatedEventArgs args)
        {
            // Проверяем, что активация произошла из-за уведомления
            if (args.Kind == ActivationKind.ToastNotification)
            {
                // Приводим аргументы к нужному типу
                var toastArgs = args as ToastNotificationActivatedEventArgs;
                // Получаем аргумент, который мы добавили в уведомление
                var arguments = toastArgs.Argument;

                // Получаем корневой фрейм приложения
                Frame rootFrame = Window.Current.Content as Frame;
                // Если фрейма нет, то создаем его
                if (rootFrame == null)
                {
                    rootFrame = new Frame();
                    rootFrame.NavigationFailed += OnNavigationFailed;
                    Window.Current.Content = rootFrame;
                }
                // Переходим на страницу NavigationBarPage
                rootFrame.Navigate(typeof(NavigationBarPage));
                // Активируем окно приложения
                Window.Current.Activate();
                // Extend acrylic
                ExtendAcrylicIntoTitleBar(); // ПРОЗРАЧНЫЙ ВЕРХНИЙ БАР
            }
        }

        // ПРОЗРАЧНЫЙ ВЕРХНИЙ БАР
        private void ExtendAcrylicIntoTitleBar()
        {
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }

        /// <summary>
        /// Вызывается в случае сбоя навигации на определенную страницу
        /// </summary>
        /// <param name="sender">Фрейм, для которого произошел сбой навигации</param>
        /// <param name="e">Сведения о сбое навигации</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Вызывается при приостановке выполнения приложения.  Состояние приложения сохраняется
        /// без учета информации о том, будет ли оно завершено или возобновлено с неизменным
        /// содержимым памяти.
        /// </summary>
        /// <param name="sender">Источник запроса приостановки.</param>
        /// <param name="e">Сведения о запросе приостановки.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Сохранить состояние приложения и остановить все фоновые операции
            deferral.Complete();
        }
    }
}