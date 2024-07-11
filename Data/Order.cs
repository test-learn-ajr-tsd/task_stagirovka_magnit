namespace ЗаданиеТестСтажировкаМагнитПриложениеBlazor.Data
{
    public enum Units
    {
        штуки, килограммы, литры
    }

    public class Order
    {
        public int Id { get; set; }
        public ProductList Product {  get; set; }
        public Units Unit { get; set; } = Units.штуки;
        public float CountOfProduct { get; set; } = 1;
        public DateOnly OrderDate {  get; set; } = new();
        public DateOnly LoadDate { get; set; } = new();
        public Manufacturer Manufacturer { get; set; }
        public string? CorrectionReason {  get; set; }
    }
}
