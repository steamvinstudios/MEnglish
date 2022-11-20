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
        #region Words Collection
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
                EnglishForm = "test",
                RussianForm = "тест",
                Image = "/ArrayPics/beout.jpg"
            },
            new Word
            {
                EnglishForm = "новый",
                RussianForm = "новый",
                Image = "/ArrayPics/beout.jpg"
            },
          /*  new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "break down" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "сломать" },new RussianForm { Form = "сломаться" }, new RussianForm { Form = "перестать работать" } },
                Image = "/ArrayPics/breakdown.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "break into" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "врываться" }, new RussianForm { Form = "вломиться" } },
                Image = "/ArrayPics/breakinto.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "burst out" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "окликнуть" }, new RussianForm { Form = "разразиться смехом" }, new RussianForm { Form = "внезапно начинаться" } },
                Image = "/ArrayPics/burstout.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "clean up" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "чистить" }, new RussianForm { Form = "убирать" },new RussianForm { Form = "приводить в порядок" } },
                Image = "/ArrayPics/cleanup.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "check in" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "зарегистрироваться" } },
                Image = "/ArrayPics/checkin.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "check out" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "проверить" }, new RussianForm { Form = "выписаться" } },
                Image = "/ArrayPics/checkout.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "check out" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "перезвонить" } },
                Image = "/ArrayPics/callback.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "keep away" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "не подходите" } },
                Image = "/ArrayPics/keepaway.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "wake up" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "будить" }, new RussianForm { Form = "просыпаться" }, new RussianForm { Form = "бодрствовать" } },
                Image = "/ArrayPics/wakeup.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "watch out" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "осторожно" }, new RussianForm { Form = "быть начеку" },new RussianForm { Form = "настороже" } },
                Image = "/ArrayPics/watchout.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "work off" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "отработать" }, new RussianForm { Form = "отделаться" },new RussianForm { Form = "освободиться" } },
                Image = "/ArrayPics/workoff.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "work out" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "определить" }, new RussianForm { Form = "вычислить" }, new RussianForm { Form = "добиться" },new RussianForm { Form = "получаться" },new RussianForm { Form = "тренироваться" } },
                Image = "/ArrayPics/workout.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "write down" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "записать на бумаге" } },
                Image = "/ArrayPics/writedown.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "write up" } },
                RussianForms = new List<RussianForm> { new RussianForm { Form = "дописать" }, new RussianForm { Form = "придать законченный вид" } },
                Image = "/ArrayPics/writeup.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "tends" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "как правило" } },
                Image = "/ArrayPics/tends.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "often" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "довольно часто" } },
                Image = "/ArrayPics/often.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "entirely" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "полностью" } },
                Image = "/ArrayPics/entirely.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "miscellaneous" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "разное" } },
                Image = "/ArrayPics/oftmiscellaneousen.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "split" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "разделенный" } },
                Image = "/ArrayPics/split.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "proper" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "правильный" } },
                Image = "/ArrayPics/proper.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "amount" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "количество" } },
                Image = "/ArrayPics/amount.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "contributor" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "участник" } },
                Image = "/ArrayPics/contributor.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "issue" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "проблема" } },
                Image = "/ArrayPics/issue.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "beware" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "остерегаться" } },
                Image = "/ArrayPics/beware.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "milk" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "молоко" } },
                Image = "/ArrayPics/milk.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "sound" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "звук" } },
                Image = "/ArrayPics/sound.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "shows off" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "красоваться" } },
                Image = "/ArrayPics/showsoff.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "further delays" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "дальнейшие задержки" } },
                Image = "/ArrayPics/furtherdelays.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "upcoming" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "предстоящий" } },
                Image = "/ArrayPics/upcoming.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "over here" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "здесь, сюда" } },
                Image = "/ArrayPics/overhere.jpg"
            },*/
        };
        #endregion

        public Words()
        {

        }
    }
}
