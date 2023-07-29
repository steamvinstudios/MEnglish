using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class AboutPageViewModel : BaseViewModel
    {
        public string LastUpdate { get; } = "Обновление от: 29.7.2023";
        public string AppVersion { get; } = "Версия: 11.8 Store Edition";
        private int rectanleRotation;
        public int RectanleRotation
        {
            get => rectanleRotation;
            private set => SetProperty(ref rectanleRotation, value);
        }
        private int rectanle1Rotation;
        public int Rectanle1Rotation
        {
            get => rectanle1Rotation;
            private set => SetProperty(ref rectanle1Rotation, value);
        }
        private int rectanle2Rotation;
        public int Rectanle2Rotation
        {
            get => rectanle2Rotation;
            private set => SetProperty(ref rectanle2Rotation, value);
        }
        private int rectanle3Rotation;
        public int Rectanle3Rotation
        {
            get => rectanle3Rotation;
            private set => SetProperty(ref rectanle3Rotation, value);
        }
        private int rectanle4Rotation;
        public int Rectanle4Rotation
        {
            get => rectanle4Rotation;
            private set => SetProperty(ref rectanle4Rotation, value);
        }
        private int rectanle5Rotation;
        public int Rectanle5Rotation
        {
            get => rectanle5Rotation;
            private set => SetProperty(ref rectanle5Rotation, value);
        }
        public AboutPageViewModel() => StartRectanglesAnimationAsync();
        public async void StartRectanglesAnimationAsync()
        {
            while (true)
            {
                await Task.Delay(1000);
                RectanleRotation = new Random().Next(360);
                Rectanle1Rotation = new Random().Next(360);
                Rectanle2Rotation = new Random().Next(360);
                Rectanle3Rotation = new Random().Next(360);
                Rectanle4Rotation = new Random().Next(360);
                Rectanle5Rotation = new Random().Next(360);
            }
        }
    }
}
