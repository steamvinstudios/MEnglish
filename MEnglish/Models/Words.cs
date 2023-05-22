using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Words
    {
        public ObservableCollection<Word> All { get; set; } = new ObservableCollection<Word>
        {
            new Word
            {
                EnglishForm = "hello",
                RussianForm = "привет",
                Image = "/ArrayPics/hello.jpg"
            },
            new Word
            {
                EnglishForm = "apple",
                RussianForm = "яблоко",
                Image = "/ArrayPics/apple.jpg"
            },
            new Word
            {
                EnglishForm = "bye",
                RussianForm = "пока",
                Image = "/ArrayPics/bye.jpg"
            },
            new Word
            {
                EnglishForm = "bridge",
                RussianForm = "мост",
                Image = "/ArrayPics/bridge.jpg"
            },
            new Word
            {
                EnglishForm = "jungle",
                RussianForm = "джунгли",
                Image = "/ArrayPics/jungle.jpg"
            },
            new Word
            {
                EnglishForm = "forest",
                RussianForm = "лес",
                Image = "/ArrayPics/forest.jpg"
            },
            new Word
            {
                EnglishForm = "animal",
                RussianForm = "животное",
                Image = "/ArrayPics/animal.jpg"
            },
            new Word
            {
                EnglishForm = "area",
                RussianForm = "зона",
                Image = "/ArrayPics/area.jpg"
            },
            new Word
            {
                EnglishForm = "book",
                RussianForm = "книга",
                Image = "/ArrayPics/book.jpg"
            },
            new Word
            {
                EnglishForm = "camera",
                RussianForm = "камера",
                Image = "/ArrayPics/camera.jpg"
            },
            new Word
            {
                EnglishForm = "coffee",
                RussianForm = "кофе",
                Image = "/ArrayPics/coffee.jpg"
            },
            new Word
            {
                EnglishForm = "end",
                RussianForm = "конец",
                Image = "/ArrayPics/end.jpg"
            },
            new Word
            {
                EnglishForm = "eye",
                RussianForm = "глаз",
                Image = "/ArrayPics/eye.jpg"
            },
            new Word
            {
                EnglishForm = "farm",
                RussianForm = "ферма",
                Image = "/ArrayPics/farm.jpg"
            },
            new Word
            {
                EnglishForm = "feet",
                RussianForm = "ноги",
                Image = "/ArrayPics/feet.jpg"
            },
            new Word
            {
                EnglishForm = "fire",
                RussianForm = "огонь",
                Image = "/ArrayPics/fire.jpg"
            },
            new Word
            {
                EnglishForm = "food",
                RussianForm = "еда",
                Image = "/ArrayPics/food.jpg"
            },
            new Word
            {
                EnglishForm = "grow",
                RussianForm = "расти",
                Image = "/ArrayPics/grow.jpg"
            },
            new Word
            {
                EnglishForm = "half",
                RussianForm = "половина",
                Image = "/ArrayPics/half.jpg"
            },
            new Word
            {
                EnglishForm = "hand",
                RussianForm = "рука",
                Image = "/ArrayPics/hand.jpg"
            },
            new Word
            {
                EnglishForm = "help",
                RussianForm = "помощь",
                Image = "/ArrayPics/help.jpg"
            },
            new Word
            {
                EnglishForm = "horse",
                RussianForm = "лошадь",
                Image = "/ArrayPics/horse.jpg"
            },
            new Word
            {
                EnglishForm = "idea",
                RussianForm = "идея",
                Image = "/ArrayPics/idea.jpg"
            },
            new Word
            {
                EnglishForm = "land",
                RussianForm = "земля",
                Image = "/ArrayPics/land.jpg"
            },
            new Word
            {
                EnglishForm = "letter",
                RussianForm = "письмо",
                Image = "/ArrayPics/letter.jpg"
            },
            new Word
            {
                EnglishForm = "mint",
                RussianForm = "мята",
                Image = "/ArrayPics/mint.jpg"
            },
            new Word
            {
                EnglishForm = "near",
                RussianForm = "близко",
                Image = "/ArrayPics/near.jpg"
            },
            new Word
            {
                EnglishForm = "need",
                RussianForm = "необходимость",
                Image = "/ArrayPics/need.jpg"
            },
            new Word
            {
                EnglishForm = "order",
                RussianForm = "порядок",
                Image = "/ArrayPics/order.jpg"
            },
            new Word
            {
                EnglishForm = "part",
                RussianForm = "часть",
                Image = "/ArrayPics/part.jpg"
            },
            new Word
            {
                EnglishForm = "plant",
                RussianForm = "растение",
                Image = "/ArrayPics/plant.jpg"
            },
            new Word
            {
                EnglishForm = "round",
                RussianForm = "круглый",
                Image = "/ArrayPics/round.jpg"
            },
            new Word
            {
                EnglishForm = "sea",
                RussianForm = "море",
                Image = "/ArrayPics/sea.jpg"
            },
            new Word
            {
                EnglishForm = "small",
                RussianForm = "маленький",
                Image = "/ArrayPics/small.jpg"
            },
            new Word
            {
                EnglishForm = "star",
                RussianForm = "звезда",
                Image = "/ArrayPics/star.jpg"
            },
            new Word
            {
                EnglishForm = "strawberry",
                RussianForm = "клубника",
                Image = "/ArrayPics/strawberry.jpg"
            },
            new Word
            {
                EnglishForm = "study",
                RussianForm = "изучать",
                Image = "/ArrayPics/study.jpg"
            },
            new Word
            {
                EnglishForm = "surface",
                RussianForm = "поверхность",
                Image = "/ArrayPics/surface.jpg"
            },
            new Word
            {
                EnglishForm = "table",
                RussianForm = "стол",
                Image = "/ArrayPics/table.jpg"
            },
            new Word
            {
                EnglishForm = "tea",
                RussianForm = "чай",
                Image = "/ArrayPics/tea.jpg"
            },
            new Word
            {
                EnglishForm = "time",
                RussianForm = "время",
                Image = "/ArrayPics/time.jpg"
            },
            new Word
            {
                EnglishForm = "walk",
                RussianForm = "прогулка",
                Image = "/ArrayPics/walk.jpg"
            },
            new Word
            {
                EnglishForm = "watch",
                RussianForm = "часы",
                Image = "/ArrayPics/watch.jpg"
            },
            new Word
            {
                EnglishForm = "way",
                RussianForm = "путь",
                Image = "/ArrayPics/way.jpg"
            },
            new Word
            {
                EnglishForm = "wind",
                RussianForm = "ветер",
                Image = "/ArrayPics/wind.jpg"
            },
            new Word
            {
                EnglishForm = "write",
                RussianForm = "писать",
                Image = "/ArrayPics/write.jpg"
            },
            new Word
            {
                EnglishForm = "ask for",
                RussianForm = "просить",
                Image = "/ArrayPics/askfor.jpg"
            },
            new Word
            {
                EnglishForm = "be out",
                RussianForm = "отсутствовать",
                Image = "/ArrayPics/beout.jpg"
            },
            new Word
            {
                EnglishForm = "cake",
                RussianForm = "торт",
                Image = "/ArrayPics/cake.jpg"
            },
            new Word
            {
                EnglishForm = "honey",
                RussianForm = "мёд",
                Image = "/ArrayPics/honey.jpg"
            },
            new Word
            {
                EnglishForm = "winter",
                RussianForm = "зима",
                Image = "/ArrayPics/winter.jpg"
            },
            new Word
            {
                EnglishForm = "snowball",
                RussianForm = "снежок",
                Image = "/ArrayPics/snowball.jpg"
            },
            new Word
            {
                EnglishForm = "snowman",
                RussianForm = "снеговик",
                Image = "/ArrayPics/snowman.jpg"
            },
            new Word
            {
                EnglishForm = "ice",
                RussianForm = "лёд",
                Image = "/ArrayPics/ice.jpg"
            },
            new Word
            {
                EnglishForm = "window",
                RussianForm = "окно",
                Image = "/ArrayPics/window.jpg"
            },
            new Word
            {
                EnglishForm = "intend",
                RussianForm = "намереваться",
                Image = "/ArrayPics/intend.jpg"
            },
            new Word
            {
                EnglishForm = "milk",
                RussianForm = "молоко",
                Image = "/ArrayPics/milk.jpg"
            },
            new Word
            {
                EnglishForm = "sound",
                RussianForm = "звук",
                Image = "/ArrayPics/sound.jpg"
            },

            Word.CreateBuilder().SetEnglishForm("headphones")
                                .SetRussianForm("наушники")
                                .SetImage("/ArrayPics/headphones.jpg"),

            Word.CreateBuilder().SetEnglishForm("mouse")
                                .SetRussianForm("мышь")
                                .SetImage("/ArrayPics/mouse.jpg"),

            Word.CreateBuilder().SetEnglishForm("celebrate")
                                .SetRussianForm("праздновать")
                                .SetImage("/ArrayPics/celebrate.jpg"),

            Word.CreateBuilder().SetEnglishForm("check out")
                                .SetRussianForm("выписаться")
                                .SetImage("/ArrayPics/checkout.jpg"),

            Word.CreateBuilder().SetEnglishForm("keep away")
                                .SetRussianForm("не подходи")
                                .SetImage("/ArrayPics/keepaway.jpg"),

            Word.CreateBuilder().SetEnglishForm("watch out")
                                .SetRussianForm("быть начеку")
                                .SetImage("/ArrayPics/watchout.jpg"),

            Word.CreateBuilder().SetEnglishForm("garland")
                                .SetRussianForm("гирлянда")
                                .SetImage("/ArrayPics/garland.jpg"),

            Word.CreateBuilder().SetEnglishForm("tinsel")
                                .SetRussianForm("мишура")
                                .SetImage("/ArrayPics/tinsel.jpg"),

            Word.CreateBuilder().SetEnglishForm("wreath")
                                .SetRussianForm("венок")
                                .SetImage("/ArrayPics/wreath.jpg"),

            Word.CreateBuilder().SetEnglishForm("toys")
                                .SetRussianForm("игрушки")
                                .SetImage("/ArrayPics/toys.jpg"),

            Word.CreateBuilder().SetEnglishForm("decoration")
                                .SetRussianForm("украшение")
                                .SetImage("/ArrayPics/decoration.jpg"),

            Word.CreateBuilder().SetEnglishForm("ginger bread")
                                .SetRussianForm("имбирный пряник")
                                .SetImage("/ArrayPics/gingerbread.jpg"),

            Word.CreateBuilder().SetEnglishForm("cranberry sauce")
                                .SetRussianForm("клюквенный соус")
                                .SetImage("/ArrayPics/cranberrysauce.jpg"),

            Word.CreateBuilder().SetEnglishForm("gift")
                                .SetRussianForm("подарок")
                                .SetImage("/ArrayPics/gift.jpg"),

            Word.CreateBuilder().SetEnglishForm("unwrap")
                                .SetRussianForm("развёртывать")
                                .SetImage("/ArrayPics/unwrap.jpg"),

            Word.CreateBuilder().SetEnglishForm("sleigh")
                                .SetRussianForm("сани")
                                .SetImage("/ArrayPics/sleigh.jpg"),

            Word.CreateBuilder().SetEnglishForm("you")
                                .SetRussianForm("ты")
                                .SetImage("/ArrayPics/you.jpg"),

            Word.CreateBuilder().SetEnglishForm("i")
                                .SetRussianForm("я")
                                .SetImage("/ArrayPics/i.jpg"),

            Word.CreateBuilder().SetEnglishForm("we")
                                .SetRussianForm("мы")
                                .SetImage("/ArrayPics/we.jpg"),

            Word.CreateBuilder().SetEnglishForm("reliability")
                                .SetRussianForm("надежность")
                                .SetImage("/ArrayPics/reliability.jpg"),
        };
    }
}
