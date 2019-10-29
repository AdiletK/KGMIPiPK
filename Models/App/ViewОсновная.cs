using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class ViewОсновная
    {
        public string Курс { get; set; }
        public string Группа { get; set; }
        public DateTime Дата { get; set; }
        public string Тема { get; set; }
        public string ВидЗанятия { get; set; }
        public string Преподаватель { get; set; }
        public string Слушатель { get; set; }
        public string Присутствовал { get; set; }
        public string Прим { get; set; }
        public byte? Запланировано { get; set; }
        public bool? Выбор { get; set; }
    }
}
