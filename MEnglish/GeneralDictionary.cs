using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish
{
    class GeneralDictionary
    {
        class WordObject
        {
            public string RuWord = "English";
            public string EnWord = "Russian";
        }
        class WordArray
        {
            public static WordObject[] WordObjectArray =
            {
                new WordObject(),
                new WordObject(),
                new WordObject(),
                new WordObject()
            };
        }
    }
}
