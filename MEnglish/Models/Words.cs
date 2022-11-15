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
        public Word RandomWordFromFourRandomWords { get; set; } = new Word();
        public ObservableCollection<Word> FourRandomWords { get; set; } =
            new ObservableCollection<Word>();
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
            /*new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "food" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "еда" } },
                Image = "/ArrayPics/food.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "grow" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "расти" } },
                Image = "/ArrayPics/grow.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "half" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "половина" } },
                Image = "/ArrayPics/half.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "hand" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "рука" } },
                Image = "/ArrayPics/hand.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "help" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "помощь" } },
                Image = "/ArrayPics/help.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "horse" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "лошадь" } },
                Image = "/ArrayPics/horse.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "idea" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "идея" } },
                Image = "/ArrayPics/idea.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "land" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "земля" } },
                Image = "/ArrayPics/land.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "letter" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "письмо" } },
                Image = "/ArrayPics/letter.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "mint" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "мята" } },
                Image = "/ArrayPics/mint.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "near" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "близко" } },
                Image = "/ArrayPics/near.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "need" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "необходимость" } },
                Image = "/ArrayPics/need.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "order" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "порядок" } },
                Image = "/ArrayPics/order.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "part" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "часть" } },
                Image = "/ArrayPics/part.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "plant" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "растение" } },
                Image = "/ArrayPics/plant.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "round" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "круглый" } },
                Image = "/ArrayPics/round.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "sea" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "море" } },
                Image = "/ArrayPics/sea.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "small" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "маленький" } },
                Image = "/ArrayPics/small.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "star" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "звезда" } },
                Image = "/ArrayPics/star.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "strawberry" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "клубника" } },
                Image = "/ArrayPics/strawberry.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "study" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "изучать" } },
                Image = "/ArrayPics/study.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "surface" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "поверхность" } },
                Image = "/ArrayPics/surface.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "table" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "стол" } },
                Image = "/ArrayPics/table.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "tea" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "чай" } },
                Image = "/ArrayPics/tea.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "time" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "время" } },
                Image = "/ArrayPics/time.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "walk" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "прогулка" } },
                Image = "/ArrayPics/walk.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "watch" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "часы" } },
                Image = "/ArrayPics/watch.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "way" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "путь" } },
                Image = "/ArrayPics/way.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "wind" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "ветер" } },
                Image = "/ArrayPics/wind.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "write" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "писать" } },
                Image = "/ArrayPics/write.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "ask for" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "просить" } },
                Image = "/ArrayPics/askfor.jpg"
            },
            new Word
            {
                EnglishForms = new List < EnglishForm > { new EnglishForm { Form = "be out" } },
                RussianForms = new List < RussianForm > { new RussianForm { Form = "отсутствовать" } },
                Image = "/ArrayPics/beout.jpg"
            },
            new Word
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
            //ShakeWords();
        }

        /*public void ShakeWords()
        {
            FourRandomWords.Clear();
            for (int i = 0; i < 4; i++)
                FourRandomWords.Add(All[new Random().Next(All.Count)]);
            GetRandomWordFromFourRandomWords();
        }*/

        public void GetRandomWordFromFourRandomWords() =>
            RandomWordFromFourRandomWords =
                FourRandomWords[new Random().Next(FourRandomWords.Count)];
    }
}
