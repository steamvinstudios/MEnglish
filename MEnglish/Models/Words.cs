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
                EnglishForms = new List<string> { "hello" },
                RussianForms = new List<string> { "привет" },
                Image = "/ArrayPics/hello.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "apple" },
                RussianForms = new List<string> { "яблоко" },
                Image = "/ArrayPics/apple.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "bye" },
                RussianForms = new List<string> { "пока" },
                Image = "/ArrayPics/bye.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "bridge" },
                RussianForms = new List<string> { "мост" },
                Image = "/ArrayPics/bridge.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "jungle" },
                RussianForms = new List<string> { "джунгли" },
                Image = "/ArrayPics/jungle.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "forest" },
                RussianForms = new List<string> { "лес" },
                Image = "/ArrayPics/forest.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "animal" },
                RussianForms = new List<string> { "животное" },
                Image = "/ArrayPics/animal.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "area" },
                RussianForms = new List<string> { "зона" },
                Image = "/ArrayPics/area.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "book" },
                RussianForms = new List<string> { "книга" },
                Image = "/ArrayPics/book.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "camera" },
                RussianForms = new List<string> { "камера" },
                Image = "/ArrayPics/camera.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "coffee" },
                RussianForms = new List<string> { "кофе" },
                Image = "/ArrayPics/coffee.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "end" },
                RussianForms = new List<string> { "конец" },
                Image = "/ArrayPics/end.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "eye" },
                RussianForms = new List<string> { "глаз" },
                Image = "/ArrayPics/eye.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "farm" },
                RussianForms = new List<string> { "ферма" },
                Image = "/ArrayPics/farm.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "feet" },
                RussianForms = new List<string> { "ноги" },
                Image = "/ArrayPics/feet.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "fire" },
                RussianForms = new List<string> { "огонь" },
                Image = "/ArrayPics/fire.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "food" },
                RussianForms = new List<string> { "еда" },
                Image = "/ArrayPics/food.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "grow" },
                RussianForms = new List<string> { "расти" },
                Image = "/ArrayPics/grow.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "half" },
                RussianForms = new List<string> { "половина" },
                Image = "/ArrayPics/half.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "hand" },
                RussianForms = new List<string> { "рука" },
                Image = "/ArrayPics/hand.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "help" },
                RussianForms = new List<string> { "помощь" },
                Image = "/ArrayPics/help.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "horse" },
                RussianForms = new List<string> { "лошадь" },
                Image = "/ArrayPics/horse.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "idea" },
                RussianForms = new List<string> { "идея" },
                Image = "/ArrayPics/idea.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "land" },
                RussianForms = new List<string> { "земля" },
                Image = "/ArrayPics/land.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "letter" },
                RussianForms = new List<string> { "письмо" },
                Image = "/ArrayPics/letter.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "mint" },
                RussianForms = new List<string> { "мята" },
                Image = "/ArrayPics/mint.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "near" },
                RussianForms = new List<string> { "близко" },
                Image = "/ArrayPics/near.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "need" },
                RussianForms = new List<string> { "необходимость" },
                Image = "/ArrayPics/need.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "order" },
                RussianForms = new List<string> { "порядок" },
                Image = "/ArrayPics/order.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "part" },
                RussianForms = new List<string> { "часть" },
                Image = "/ArrayPics/part.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "plant" },
                RussianForms = new List<string> { "растение" },
                Image = "/ArrayPics/plant.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "round" },
                RussianForms = new List<string> { "круглый" },
                Image = "/ArrayPics/round.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "sea" },
                RussianForms = new List<string> { "море" },
                Image = "/ArrayPics/sea.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "small" },
                RussianForms = new List<string> { "маленький" },
                Image = "/ArrayPics/small.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "star" },
                RussianForms = new List<string> { "звезда" },
                Image = "/ArrayPics/star.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "strawberry" },
                RussianForms = new List<string> { "клубника" },
                Image = "/ArrayPics/strawberry.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "study" },
                RussianForms = new List<string> { "изучать" },
                Image = "/ArrayPics/study.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "surface" },
                RussianForms = new List<string> { "поверхность" },
                Image = "/ArrayPics/surface.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "table" },
                RussianForms = new List<string> { "стол" },
                Image = "/ArrayPics/table.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "tea" },
                RussianForms = new List<string> { "чай" },
                Image = "/ArrayPics/tea.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "time" },
                RussianForms = new List<string> { "время" },
                Image = "/ArrayPics/time.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "walk" },
                RussianForms = new List<string> { "прогулка" },
                Image = "/ArrayPics/walk.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "watch" },
                RussianForms = new List<string> { "часы" },
                Image = "/ArrayPics/watch.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "way" },
                RussianForms = new List<string> { "путь" },
                Image = "/ArrayPics/way.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "wind" },
                RussianForms = new List<string> { "ветер" },
                Image = "/ArrayPics/wind.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "write" },
                RussianForms = new List<string> { "писать" },
                Image = "/ArrayPics/write.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "ask for" },
                RussianForms = new List<string> { "просить", "спрашивать", "требовать" },
                Image = "/ArrayPics/askfor.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "be out" },
                RussianForms = new List<string> { "отсутствовать" },
                Image = "/ArrayPics/beout.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "break down" },
                RussianForms = new List<string> { "сломать", "сломаться", "перестать работать" },
                Image = "/ArrayPics/breakdown.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "break into" },
                RussianForms = new List<string> { "врываться", "вломиться" },
                Image = "/ArrayPics/breakinto.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "burst out" },
                RussianForms = new List<string> { "окликнуть", "разразиться смехом", "внезапно начинаться" },
                Image = "/ArrayPics/burstout.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "clean up" },
                RussianForms = new List<string> { "чистить", "убирать", "приводить в порядок" },
                Image = "/ArrayPics/cleanup.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "check in" },
                RussianForms = new List<string> { "зарегистрироваться" },
                Image = "/ArrayPics/checkin.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "check out" },
                RussianForms = new List<string> { "проверить", "выписаться" },
                Image = "/ArrayPics/checkout.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "call back" },
                RussianForms = new List<string> { "проверить", "выписаться" },
                Image = "/ArrayPics/checkout.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "check out" },
                RussianForms = new List<string> { "перезвонить" },
                Image = "/ArrayPics/callback.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "keep away" },
                RussianForms = new List<string> { "не подходите" },
                Image = "/ArrayPics/keepaway.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "wake up" },
                RussianForms = new List<string> { "будить", "просыпаться", "бодрствовать" },
                Image = "/ArrayPics/wakeup.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "watch out" },
                RussianForms = new List<string> { "осторожно", "быть начеку", "настороже" },
                Image = "/ArrayPics/watchout.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "work off" },
                RussianForms = new List<string> { "отработать", "отделаться", "освободиться" },
                Image = "/ArrayPics/workoff.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "work out" },
                RussianForms = new List<string> { "определить", "вычислить", "добиться", "получаться", "тренироваться" },
                Image = "/ArrayPics/workout.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "write down" },
                RussianForms = new List<string> { "записать на бумаге" },
                Image = "/ArrayPics/writedown.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "write up" },
                RussianForms = new List<string> { "дописать", "придать законченный вид" },
                Image = "/ArrayPics/writeup.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "tends" },
                RussianForms = new List<string> { "как правило" },
                Image = "/ArrayPics/tends.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "often" },
                RussianForms = new List<string> { "довольно часто" },
                Image = "/ArrayPics/often.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "entirely" },
                RussianForms = new List<string> { "полностью" },
                Image = "/ArrayPics/entirely.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "miscellaneous" },
                RussianForms = new List<string> { "разное" },
                Image = "/ArrayPics/oftmiscellaneousen.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "split" },
                RussianForms = new List<string> { "разделенный" },
                Image = "/ArrayPics/split.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "proper" },
                RussianForms = new List<string> { "правильный" },
                Image = "/ArrayPics/proper.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "amount" },
                RussianForms = new List<string> { "количество" },
                Image = "/ArrayPics/amount.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "contributor" },
                RussianForms = new List<string> { "участник" },
                Image = "/ArrayPics/contributor.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "issue" },
                RussianForms = new List<string> { "проблема" },
                Image = "/ArrayPics/issue.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "beware" },
                RussianForms = new List<string> { "остерегаться" },
                Image = "/ArrayPics/beware.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "milk" },
                RussianForms = new List<string> { "молоко" },
                Image = "/ArrayPics/milk.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "sound" },
                RussianForms = new List<string> { "звук" },
                Image = "/ArrayPics/sound.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "shows off" },
                RussianForms = new List<string> { "красоваться" },
                Image = "/ArrayPics/showsoff.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "further delays" },
                RussianForms = new List<string> { "дальнейшие задержки" },
                Image = "/ArrayPics/furtherdelays.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "upcoming" },
                RussianForms = new List<string> { "предстоящий" },
                Image = "/ArrayPics/upcoming.jpg"
            },
            new Word
            {
                EnglishForms = new List<string> { "over here" },
                RussianForms = new List<string> { "здесь, сюда" },
                Image = "/ArrayPics/overhere.jpg"
            },
        };
        #endregion

        public Words()
        {
            ShakeWords();
        }

        public void ShakeWords()
        {
            FourRandomWords.Clear();
            for (int i = 0; i < 4; i++)
                FourRandomWords.Add(All[new Random().Next(All.Count)]);
            GetRandomWordFromFourRandomWords();
        }

        public void GetRandomWordFromFourRandomWords() =>
            RandomWordFromFourRandomWords =
                FourRandomWords[new Random().Next(FourRandomWords.Count)];
    }
}
