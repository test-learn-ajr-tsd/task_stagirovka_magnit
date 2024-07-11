using Microsoft.AspNetCore.Components;

namespace ЗаданиеТестСтажировкаМагнитПриложениеBlazor.Data
{
    public class TestFillOrders : ComponentBase
    {
        public IEnumerable<Order> Orders { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitFillOrders();
            return base.OnInitializedAsync();
        }

        public void InitFillOrders()
        {
            Orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Product = new ProductList
                    {
                        Id = 1,
                        Name = "Сыр"
                    },
                    Unit = Units.килограммы,
                    CountOfProduct = 350.0F,
                    OrderDate = new DateOnly(2024, 6, 21),
                    LoadDate = new DateOnly(2024, 6, 22),
                    Manufacturer = new Manufacturer
                    {
                        Id = 1, Name = "Рога и Копыта"
                    }
                },
                new Order
                {
                    Id = 2,
                    Product = new ProductList
                    {
                        Id = 2,
                        Name = "Молоко"
                    },
                    Unit = Units.литры,
                    CountOfProduct = 50.25F,
                    OrderDate = new DateOnly(2024, 6, 27),
                    LoadDate = new DateOnly(2024, 6, 29),
                    Manufacturer = new Manufacturer
                    {
                        Id = 2, Name = "Чебурашка и КО"
                    }
                },
                new Order
                {
                    Id = 3,
                    Product = new ProductList
                    {
                        Id = 3,
                        Name = "Упаковка печенья"
                    },
                    Unit = Units.штуки,
                    CountOfProduct = 100,
                    OrderDate = new DateOnly(2024, 6, 26),
                    LoadDate = new DateOnly(2024, 6, 28),
                    Manufacturer = new Manufacturer
                    {
                        Id = 3, Name = "ОАО \"Любятово\""
                    }
                },
                new Order
                {
                    Id = 4,
                    Product = new ProductList
                    {
                        Id = 4,
                        Name = "Сладкая вода"
                    },
                    Unit = Units.штуки,
                    CountOfProduct = 100,
                    OrderDate = new DateOnly(2024, 6, 26),
                    LoadDate = new DateOnly(2024, 6, 28),
                    Manufacturer = new Manufacturer
                    {
                        Id = 3, Name = "ОАО \"Сладкая вода\""
                    }, 
                    CorrectionReason = "Дозаказ"
                },
                                new Order
                {
                    Id = 5,
                    Product = new ProductList
                    {
                        Id = 5,
                        Name = "Вода \"Чистая линия\""
                    },
                    Unit = Units.штуки,
                    CountOfProduct = 100,
                    OrderDate = new DateOnly(2024, 6, 26),
                    LoadDate = new DateOnly(2024, 6, 28),
                    Manufacturer = new Manufacturer
                    {
                        Id = 3, Name = "ОАО \"Сладкая вода\""
                    },
                    CorrectionReason = "Некая причина дозаказа"
                }
            };
        }
    }
}
