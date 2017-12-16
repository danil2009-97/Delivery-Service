namespace DeliveryServiceLogic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<DeliveryServiceLogic.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DeliveryServiceLogic.Context context)
        {
            //ShopType[] shopTypes =
            //{
            //    new ShopType
            //    {
            //        Name = "Итальянская"
            //    },

            //    new ShopType
            //    {
            //        Name = "Русская"
            //    },

            //    new ShopType
            //    {
            //        Name = "Кавказская"
            //    },

            //    new ShopType
            //    {
            //        Name = "Японская"
            //    },

            //    new ShopType
            //    {
            //        Name = "Американская"
            //    },

            //    new ShopType
            //    {
            //        Name = "Мексиканская"
            //    },

            //    new ShopType
            //    {
            //        Name = "Французская"
            //    },
            //};

            //Shop[] shops =
            //{
            //    new Shop
            //    {
            //        Name = "La Provincia",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 1),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат \"Капрезе\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "Помидоры, сыр \"Моцарелла\", базилик",
            //                Price = 780,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Салат с перепелами",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "Микс салата, перепелка гриль, перепелиное яйцо, помидоры черри, пикантный соус",
            //                Price = 920,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.5,
            //        AvgCheck = 1500,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Елки-Палки",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 2),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат \"Итальянский\" с лососем",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 280,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Винегрет \"По-домашнему\" с селедочкой",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 920,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.3,
            //        AvgCheck = 130,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "ДжонДжоли",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат \"Багратиони\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 340,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Салат \"Цезария\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 360,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.9,
            //        AvgCheck = 2000,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Тануки",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 4),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Цезарь-сан с курицей",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 330,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Дайкани сарада",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 370,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.4,
            //        AvgCheck = 950,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Frendy's",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 5),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат из свежих овощей",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 310,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Салат \"Цезарь\" с семгой на грилле",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 470,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.65,
            //        AvgCheck = 1200,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Сомбреро",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 6),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат \"Акапулько\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 500,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Салат \"Мачу-пикчу\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 460,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 3.7,
            //        AvgCheck = 1250,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Chateau de Fleurs",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 7),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат из томленой гусиной грудки",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 760,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Салат теплый из телячьей вырезки",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 960,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 5,
            //        AvgCheck = 1500,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Папа Джонс",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 1),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Пицца \"Маргарита\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
            //                Description = "",
            //                Price = 500,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Пицца \"Мясная\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
            //                Description = "",
            //                Price = 675,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.2,
            //        AvgCheck = 500,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Кабанчик",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Салат из авокадо",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 650,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Салат \"Столичный\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 310,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.3,
            //        AvgCheck = 1750,
            //        LogoPath = ""
            //    },

            //    new Shop
            //    {
            //        Name = "Hard Rock Cafe",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 5),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "Легендарный бургер",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
            //                Description = "",
            //                Price = 750,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "Швейцарский бургер с грибами",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
            //                Description = "",
            //                Price = 775,
            //                LogoPath = ""
            //            }
            //        },
            //        Rating = 4.9,
            //        AvgCheck = 1400,
            //        LogoPath = ""
            //    }
            //};

            //ProductType[] productTypes =
            //{
            //    new ProductType
            //    {
            //        Name = "Пицца"
            //    },

            //    new ProductType
            //    {
            //        Name = "Бургеры"
            //    },

            //    new ProductType
            //    {
            //        Name = "Суши и роллы"
            //    },

            //    new ProductType
            //    {
            //        Name = "Мясо"
            //    },

            //    new ProductType
            //    {
            //        Name = "Напитки"
            //    },

            //    new ProductType
            //    {
            //        Name = "Закуски"
            //    },

            //    new ProductType
            //    {
            //        Name = "Салаты"
            //    },

            //    new ProductType
            //    {
            //        Name = "Супы"
            //    },

            //    new ProductType
            //    {
            //        Name = "Гарниры"
            //    },

            //    new ProductType
            //    {
            //        Name = "Десерты"
            //    },

            //    new ProductType
            //    {
            //        Name = "Выпечка"
            //    },
            //};

            //context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            //context.Shops.AddOrUpdate(s => s.Name, shops);
            //context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);
        }
    }
}
