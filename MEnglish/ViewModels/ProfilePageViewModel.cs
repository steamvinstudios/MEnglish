using CommunityToolkit.Mvvm.ComponentModel;
using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class ProfilePageViewModel : BaseViewModel
    {
        public Words AppWords { get; set; } = new Words();
    }
}
