﻿using CommunityToolkit.Mvvm.Input;
using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace MEnglish.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public News News { get; set; } = new News();
    }
}
