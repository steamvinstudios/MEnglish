using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEnglish.Models
{
    public class News
    {
        public List<Article> All { get; set; } = new List<Article>
        {
            new Article
            {
                Title = "Профиль",
                Body = "Теперь в разделе [🥇Профиль] можно просматривать прогресс изучения слов. В приложение интегрирована база данных - обеспечено сохранение прогресса на диск. Также, по клику можно добавлять свои собственные, либо изменять и удалять существующие слова. Путь к картинке можно вставлять по ссылке из интернета",
                Date = new DateTime(22, 12, 2)
            },

            new Article
            {
                Title = "Сброс слов",
                Body = "Добавлены новые слова. Теперь приложение подстраивается под Вас. Знает, какие слова Вам лучше изучить/повторить сейчас, а какие оставить на потом. Для обновления слов зайдите в раздел [🥇Профиль], кликните по любому слову и нажмите [Сбросить слова]",
                Date = new DateTime(22, 12, 7)
            },


        };
    }
}
