using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.ViewModels
{
    public class HistoryPageViewModel : BaseViewModel
    {
        public History History { get; set; } = new History();
    }
}
