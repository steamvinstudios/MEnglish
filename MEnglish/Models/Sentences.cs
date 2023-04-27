using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Sentences
    {
        public ObservableCollection<Sentence> Collection { get; set; } = new ObservableCollection<Sentence>
        {
            new Sentence
            {
                English = "i love you",
                Russian = "я люблю тебя"
            },
            new Sentence
            {
                English = "let's go",
                Russian = "пошли"
            },
            new Sentence
            {
                English = "i want to drink",
                Russian = "я хочу пить"
            },
            new Sentence
            {
                English = "what's new?",
                Russian = "что нового?"
            },
            new Sentence
            {
                English = "how are things?",
                Russian = "как дела?"
            },
            new Sentence
            {
                English = "how's life?",
                Russian = "как жизнь?"
            },
            new Sentence
            {
                English = "how was your weekend?",
                Russian = "как прошли выходные?"
            },
            new Sentence
            {
                English = "i really appreciate it!",
                Russian = "я очень благодарен"
            },
            new Sentence
            {
                English = "I’m fine, thanks. How about you?",
                Russian = "Все хорошо, спасибо. Как насчет тебя?"
            },
            new Sentence
            {
                English = "Pretty good",
                Russian = "Довольно хорошо"
            },
            new Sentence
            {
                English = "Same as always",
                Russian = "Как всегда"
            },
            new Sentence
            {
                English = "Not so great",
                Russian = "Не так здорово"
            },
            new Sentence
            {
                English = "Could be better",
                Russian = "Могло быть лучше"
            },
            new Sentence
            {
                English = "I’m really grateful",
                Russian = "Я действительно благодарен"
            },
            new Sentence
            {
                English = "That’s so kind of you",
                Russian = "Это так любезно с твоей стороны"
            },
            new Sentence
            {
                English = "No problem",
                Russian = "Нет проблем"
            },
            new Sentence
            {
                English = "No worries",
                Russian = "Не беспокойся"
            },
            new Sentence
            {
                English = "Don’t mention it",
                Russian = "не за что"
            },
            new Sentence
            {
                English = "My pleasure",
                Russian = "Рад помочь"
            },
            new Sentence
            {
                English = "Anytime",
                Russian = "Всегда рад помочь"
            },
            new Sentence
            {
                English = "My name is … What’s your name?",
                Russian = "Меня зовут … Как тебя зовут?"
            },
            new Sentence
            {
                English = "Nice to meet you!",
                Russian = "Приятно познакомиться!"
            },
            new Sentence
            {
                English = "Pleased to meet you!",
                Russian = "Рад познакомиться!"
            },
            new Sentence
            {
                English = "It’s a pleasure!",
                Russian = "Счастлив познакомиться"
            },
            new Sentence
            {
                English = "Where are you from?",
                Russian = "Откуда ты"
            },
            new Sentence
            {
                English = "What do you do?",
                Russian = "Чем вы занимаетесь?"
            },
            new Sentence
            {
                English = "I have no idea",
                Russian = "Не имею понятия"
            },
            new Sentence
            {
                English = "I can’t help you there",
                Russian = "Не могу помочь"
            },
            new Sentence
            {
                English = "Beats me",
                Russian = "Без понятия"
            },
            new Sentence
            {
                English = "I’m not really sure. Let me check on that!",
                Russian = "Я не совсем уверен. Я уточню этот вопрос"
            },
            new Sentence
            {
                English = "I’ve been wondering that, too",
                Russian = "Мне это тоже интересно"
            },
            new Sentence
            {
                English = "Exactly!",
                Russian = "Именно"
            },
            new Sentence
            {
                English = "Absolutely!",
                Russian = "Безусловно"
            },
            new Sentence
            {
                English = "That’s (so) true",
                Russian = "Это (абсолютная) правда"
            },
            new Sentence
            {
                English = "I couldn’t agree with you more",
                Russian = "Не могу не согласиться"
            },
            new Sentence
            {
                English = "Tell me about it!",
                Russian = "И не говори!"
            },
            new Sentence
            {
                English = "I’ll say!",
                Russian = "Еще бы!"
            },
            new Sentence
            {
                English = "I suppose so",
                Russian = "Полагаю, что так"
            },
            new Sentence
            {
                English = "I’m not so sure about that",
                Russian = "Я в этом не уверен"
            },
            new Sentence
            {
                English = "That’s not how I see it",
                Russian = " Я на это смотрю по другому"
            },
            new Sentence
            {
                English = "Not necessarily",
                Russian = "Необязательно"
            },
            new Sentence
            {
                English = "That’s great!",
                Russian = "Это отлично!"
            },
            new Sentence
            {
                English = "How wonderful!",
                Russian = "Как замечательно!"
            },
            new Sentence
            {
                English = "Awesome!",
                Russian = "Великолепно!"
            },
            new Sentence
            {
                English = "Oh no…",
                Russian = "О, нет…"
            },
            new Sentence
            {
                English = "That’s terrible",
                Russian = "Это ужасно"
            },
            new Sentence
            {
                English = "Poor you",
                Russian = "Бедный (бедняга)"
            },
            new Sentence
            {
                English = "I’m so sorry to hear that",
                Russian = "Мне так жаль это слышать"
            },
            new Sentence
            {
                English = "Are you free…",
                Russian = "Ты свободен…"
            },
            new Sentence
            {
                English = "Are you doing anything…",
                Russian = "Ты занят…"
            },
            new Sentence
            {
                English = "Would you like to…",
                Russian = "Не хотел бы ты…"
            },
            new Sentence
            {
                English = "Would you like to…",
                Russian = "Не согласитесь ли…"
            },
            new Sentence
            {
                English = "It’s a little chilly",
                Russian = "Немного прохладно"
            },
            new Sentence
            {
                English = "It’s freezing!",
                Russian = "на улице лютый холод"
            },
            new Sentence
            {
                English = "Make sure to bundle up",
                Russian = "убедись, что укутался"
            },
            new Sentence
            {
                English = "It’s absolutely boiling!",
                Russian = "невыносимая жара"
            },
            new Sentence
            {
                English = "I see",
                Russian = "Понятно"
            },
            new Sentence
            {
                English = "I don’t understand",
                Russian = "Я не понимаю"
            },
            new Sentence
            {
                English = "Could you repeat that please?",
                Russian = "Вы не могли бы повторить?"
            },
            new Sentence
            {
                English = "Could you please talk slower",
                Russian = "Вы не могли бы говорить медленнее?"
            },
            new Sentence
            {
                English = "Thank you. That helps a lot",
                Russian = "Спасибо. Это очень помогло"
            },
            new Sentence
            {
                English = "What does … mean?",
                Russian = "Что означает …?"
            },
            new Sentence
            {
                English = "How do you spell that?",
                Russian = "Как это пишется?"
            },
            new Sentence
            {
                English = "What do you mean?",
                Russian = "Что ты имеешь в виду?"
            },
            new Sentence
            {
                English = "Got it, thanks!",
                Russian = "Понял, спасибо!"
            },
            new Sentence
            {
                English = "Break a leg",
                Russian = "Ни пуха, ни пера"
            },
            new Sentence
            {
                English = "Hang in there",
                Russian = "Держись там"
            },
            new Sentence
            {
                English = "Miss the boat",
                Russian = "Поезд ушел"
            },
            new Sentence
            {
                English = "Pull yourself together",
                Russian = "Собраться"
            },
            new Sentence
            {
                English = "To make matters worse…",
                Russian = "Что еще хуже…"
            },
            new Sentence
            {
                English = "Break the ice",
                Russian = "Растопить лед"
            },
            new Sentence
            {
                English = "Something Rocks!",
                Russian = "Круто"
            },
            new Sentence
            {
                English = "Freak out",
                Russian = "Сходить с ума"
            },
            new Sentence
            {
                English = "It’s a piece of cake",
                Russian = "Это совсем просто!"
            },
            new Sentence
            {
                English = "Burn bridges",
                Russian = "Сжигать мосты"
            },
        };
    }
}
