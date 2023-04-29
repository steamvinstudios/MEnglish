using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class Verbs
    {
        public ObservableCollection<Verb> Collection { get; set; } = new ObservableCollection<Verb>
        {
            new Verb
            {
                English = "Be out",
                Russian = "отсутствовать"
            },
            new Verb
            {
                English = "Be off",
                Russian = "уезжать, уходить, быть неработающим, свободным"
            },
            new Verb
            {
                English = "Be over",
                Russian = "завершиться, окончиться"
            },
            new Verb
            {
                English = "Beupto",
                Russian = "намереваться, собираться что-то сделать, зависеть от"
            },
            new Verb
            {
                English = "Break in",
                Russian = "вламываться, врываться, вмешиваться (в разговор)"
            },
            new Verb
            {
                English = "Break down",
                Russian = "сломаться, сломать, выйти из строя"
            },
            new Verb
            {
                English = "Calm down",
                Russian = "успокаиваться, успокаивать"
            },
            new Verb
            {
                English = "Call back",
                Russian = "перезвонить, позвать назад"
            },
            new Verb
            {
                English = "Carry on",
                Russian = "продолжать заниматься чем-то"
            },
            new Verb
            {
                English = "Check in",
                Russian = "регистрироваться, зарегистрировать"
            },
            new Verb
            {
                English = "Check out",
                Russian = "выписаться из, выяснять, проверять"
            },
            new Verb
            {
                English = "Clean up",
                Russian = "убирать, приводить в порядок"
            },
            new Verb
            {
                English = "Come along",
                Russian = "приходить, появляться, идти вместе, сопровождать"
            },
            new Verb
            {
                English = "Come across",
                Russian = "случайно встретить, натолкнуться на"
            },
            new Verb
            {
                English = "Come from",
                Russian = "происходить от / из, взяться"
            },
            new Verb
            {
                English = "Come on",
                Russian = "приходить, проходить, давай! / брось! /пошли! /кончай!"
            },
            new Verb
            {
                English = "Come in",
                Russian = "входить, прибывать, приходить"
            },
            new Verb
            {
                English = "Come over",
                Russian = "заезжать, подходить, приходить, охватывать"
            },
            new Verb
            {
                English = "Cut off",
                Russian = "отрезать, прерывать"
            },
            new Verb
            {
                English = "Count on",
                Russian = "рассчитывать на, возлагать надежду"
            },
            new Verb
            {
                English = "End up",
                Russian = "закончить, попасть, оказаться"
            },
            new Verb
            {
                English = "Fall down",
                Russian = "упасть, падать, рухнуть"
            },
            new Verb
            {
                English = "Figure out",
                Russian = "выяснить, сообразить, понять, разобраться"
            },
            new Verb
            {
                English = "Find out",
                Russian = "найти, обнаружить, выяснить, разузнать"
            },
            new Verb
            {
                English = "Get away",
                Russian = "уходить, удрать, ускользнуть"
            },
            new Verb
            {
                English = "Get down",
                Russian = "опустить, опуститься"
            },
            new Verb
            {
                English = "Get in",
                Russian = "забраться в, проникнуть, войти"
            },
            new Verb
            {
                English = "Get off",
                Russian = "покидать, выходить, уносить, удалять, уходи!"
            },
            new Verb
            {
                English = "Get on",
                Russian = "садиться на / в, продолжить, приступить к"
            },
            new Verb
            {
                English = "Get out",
                Russian = "выходить, вытаскивать, уходить"
            },
            new Verb
            {
                English = "Get up",
                Russian = "вставать, просыпаться"
            },
            new Verb
            {
                English = "Go away",
                Russian = "уезжать, уходить"
            },
            new Verb
            {
                English = "Go off",
                Russian = "убегать, улетать, уходить, уезжать"
            },
            new Verb
            {
                English = "Go in",
                Russian = "входить"
            },
            new Verb
            {
                English = "Go on",
                Russian = "продолжать, происходить, продолжайте!"
            },
            new Verb
            {
                English = "Go through",
                Russian = "пройти через, тщательно изучать, повторять"
            },
            new Verb
            {
                English = "Grow up",
                Russian = "вырастать, становиться взрослым"
            },
            new Verb
            {
                English = "Hang on",
                Russian = "цепляться, хвататься, полагаться, рассчитывать на кого-то"
            },
            new Verb
            {
                English = "Help out",
                Russian = "помогать, выручать"
            },
            new Verb
            {
                English = "Hold on",
                Russian = "продолжать дело, несмотря на трудности, подождите! Оставайтесь на линии!"
            },
            new Verb
            {
                English = "Keep up",
                Russian = "продолжать, не отставать, поддерживать"
            },
            new Verb
            {
                English = "Keep on",
                Russian = "продолжать"
            },
            new Verb
            {
                English = "Knock down",
                Russian = "сносить, разрушать, сбить с ног"
            },
            new Verb
            {
                English = "Let in",
                Russian = "впускать"
            },
            new Verb
            {
                English = "Lie down",
                Russian = "прилечь, лечь"
            },
            new Verb
            {
                English = "Line up",
                Russian = "становиться в линию, ряд, очередь"
            },
            new Verb
            {
                English = "Look back",
                Russian = "оборачиваться, оглядываться"
            },
            new Verb
            {
                English = "Look forward to",
                Russian = "ожидать чего-то с нетерпением"
            },
            new Verb
            {
                English = "Look for",
                Russian = "искать, присматривать"
            },
            new Verb
            {
                English = "Move on",
                Russian = "продолжать движение, идти дальше"
            },
            new Verb
            {
                English = "Move in",
                Russian = "входить, въезжать (поселяться)"
            },
            new Verb
            {
                English = "Pass out",
                Russian = "терять сознание, раздавать"
            },
            new Verb
            {
                English = "Pick up",
                Russian = "подобрать, подхватить, взять, поднять (любой предмет, сигнал, человека, запах и т.д.)"
            },
            new Verb
            {
                English = "Pull on",
                Russian = "тянуть (на себя), натягивать (надевать)"
            },
            new Verb
            {
                English = "Put in",
                Russian = "вставлять"
            },
            new Verb
            {
                English = "Put on",
                Russian = "одевать, надевать, включать"
            },
            new Verb
            {
                English = "Put down",
                Russian = "опустить, положить"
            },
            new Verb
            {
                English = "Put up",
                Russian = "строить, поднимать, финансировать"
            },
            new Verb
            {
                English = "Run out",
                Russian = "истощаться, кончаться, выбегать"
            },
            new Verb
            {
                English = "Run into",
                Russian = "столкнуться, встретить, наскочить"
            },
            new Verb
            {
                English = "Run over",
                Russian = "переехать, задавить, столкнуться"
            },
            new Verb
            {
                English = "Run away",
                Russian = "удирать, убегать"
            },
            new Verb
            {
                English = "Set up",
                Russian = "создавать, организовывать, устраивать"
            },
            new Verb
            {
                English = "Show up",
                Russian = "приходить, появляться"
            },
            new Verb
            {
                English = "Settle down",
                Russian = "поселяться, успокаиваться, усаживаться"
            },
            new Verb
            {
                English = "Sit down",
                Russian = "садиться, успокаиваться, поселяться"
            },
            new Verb
            {
                English = "Shut up",
                Russian = "заткнуть, заставить замолчать, заткнись!"
            },
            new Verb
            {
                English = "Shut down",
                Russian = "выключить, отключить, закрыть"
            },
            new Verb
            {
                English = "Stand by",
                Russian = "приготовиться, поддерживать, ждать"
            },
            new Verb
            {
                English = "Switch on",
                Russian = "включать"
            },
            new Verb
            {
                English = "Switch off",
                Russian = "выключать"
            },
            new Verb
            {
                English = "Take away",
                Russian = "забирать, убирать, отнимать"
            },
            new Verb
            {
                English = "Take off",
                Russian = "уходить, уезжать, снимать с себя"
            },
            new Verb
            {
                English = "Take in",
                Russian = "приютить, впустить, воспринимать, вбирать"
            },
            new Verb
            {
                English = "Throw up",
                Russian = "тошнить, рвать, поднять, выкинуть, вскинуть"
            },
            new Verb
            {
                English = "Turn around",
                Russian = "оборачиваться"
            },
            new Verb
            {
                English = "Turn into",
                Russian = "превращаться в кого-то или во что-то"
            },
            new Verb
            {
                English = "Turn on",
                Russian = "включать"
            },
            new Verb
            {
                English = "Turn off",
                Russian = "выключать, поворачивать, сворачивать"
            },
            new Verb
            {
                English = "Turn out",
                Russian = "Turn out"
            },
            new Verb
            {
                English = "Wake up",
                Russian = "просыпаться, будить"
            },
            new Verb
            {
                English = "Walk in",
                Russian = "входить"
            },
            new Verb
            {
                English = "Walk out",
                Russian = "спланировать, разобраться, понять"
            },
            new Verb
            {
                English = "Walk away",
                Russian = "уходить"
            },
            new Verb
            {
                English = "Walk off",
                Russian = "уходить"
            },
            new Verb
            {
                English = "Walk up",
                Russian = "подходить"
            },
            new Verb
            {
                English = "Work out",
                Russian = "тренироваться, понять, разобраться, спланировать"
            },
            new Verb
            {
                English = "Write down",
                Russian = "записывать"
            },
            new Verb
            {
                English = "Work up",
                Russian = "создать, выработать, расстраиваться"
            },
            new Verb
            {
                English = "Watch out",
                Russian = "быть начеку, остерегаться"
            },
        };
    }
}
