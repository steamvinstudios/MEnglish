using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class RussianForm
    {
        public int Id { get; set; }
        public string Form { get; set; }

        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
