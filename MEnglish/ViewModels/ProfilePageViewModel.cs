using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class ProfilePageViewModel : ObservableObject
    {
        public Words AppWords { get; set; } = new Words();
    }
}
