﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSYA
{
    public class EntryModel
    {
        public int Number { get; set; } // #
        public string Title { get; set; } // Название в заголовке 
        public string Rating { get; set; } // Рейтинг
        public string Vote { get; set; } // Сколько пользователей проголосовало
        public string alternativeTitle { get; set; } // Альтернативные название
        public string View { get; set; } // Количество просмотров
        public string Status { get; set; } // Статус (Онгоин, вышел и тд.)
        public string Released { get; set; } // Дата выхода
        public string Season { get; set; } // Сезон выхода
        public string ageRating { get; set; } // Возрастной рейтинг
        public string Genre { get; set; } // Жанр
        public string primarySource { get; set; } // Первоисточник
        public string Studio { get; set; } // Студия 
        public string Producer { get; set; } // Режиссер
        public string Type { get; set; } // Тип (Сериал, полнометражный, ОВА и тд.)
        public string Series { get; set; } // Количество серий
        public string transfer { get; set; } // Перевод (Многоголосный, одноголосный или субтитры)
        public string voiceActing { get; set; } // Проект который озвучил (AniDub, Anilibria и тд.)
        public string Description { get; set; } // Описание
        public string urlImage { get; set; } // Постер
        public string License { get; set; } // Издатель
        public string linkAnime { get; set; } // ссылка на аниме
    }
}
