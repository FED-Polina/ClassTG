using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    internal class Films
    {
        public string ID { get; set; }//Уникальный айди пользователя
        public string Name { get; set; }//Название фильма
        public string Genre { get; set; }//Жанр
        public string Year { get; set; }//Год выпуска
        public string AgeLimit { get; set; }//Возрастное ограничение
        public string Lasting { get; set; }//Продолжительность
        public string Description { get; set; }//Описание
        public string URL { get; set; }//Ссылка
    }
}
