using System;

namespace KGMIPiPK
{
    public partial class СводЗанятия
    {
        public string Курс { get; set; }
        public DateTime? С { get; set; }
        public DateTime? До { get; set; }
        public byte? План { get; set; }
        public string Группа { get; set; }
        public string Преподаватель { get; set; }
        public string Тема { get; set; }
        public DateTime Дата { get; set; }
        public string Слушатель { get; set; }
        public string Присутствовал { get; set; }
        public string ВидЗан { get; set; }
    }
}