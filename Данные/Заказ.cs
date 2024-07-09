namespace ЗаданиеТестСтажировкаМагнитПриложениеBlazor.Данные
{
    public enum ЕдиницыИзмерения
    {
        штуки, килограммы, литры
    }

    public class Заказ
    {
        public int Id { get; set; }
        public ТоварнаяПозиция Товар {  get; set; }
        public ЕдиницыИзмерения ЕдиницыИзмерения { get; set; } = ЕдиницыИзмерения.штуки;
        public float Количество { get; set; } = 1;
        public DateOnly ДатаЗаказа {  get; set; } = new();
        public DateOnly ДатаОтгрузки { get; set; } = new();
        public Контрагент Поставщик { get; set; }
        public string? ПричинаКорректировки {  get; set; }
    }
}
