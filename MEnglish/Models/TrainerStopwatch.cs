using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class TrainerStopwatch : ObservableObject
    {
        private string stopwatchResultEverySecond;
        public string StopwatchResultEverySecond
        {
            get => stopwatchResultEverySecond;
            set => SetProperty(ref stopwatchResultEverySecond, value);
        }
        private Stopwatch stopwatch = new Stopwatch();
        public TrainerStopwatch()
        {
            stopwatch.Start();
            UpdateStopwatchResultAsync();
        }
        private async void UpdateStopwatchResultAsync()
        {
            while (true)
            {
                await Task.Delay(1000);
                StopwatchResultEverySecond = stopwatch.Elapsed.Seconds.ToString();
            }
        }
    }
}
