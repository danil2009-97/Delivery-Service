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
            //        Name = "�����������"
            //    },

            //    new ShopType
            //    {
            //        Name = "�������"
            //    },

            //    new ShopType
            //    {
            //        Name = "����������"
            //    },

            //    new ShopType
            //    {
            //        Name = "��������"
            //    },

            //    new ShopType
            //    {
            //        Name = "������������"
            //    },

            //    new ShopType
            //    {
            //        Name = "������������"
            //    },

            //    new ShopType
            //    {
            //        Name = "�����������"
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
            //                Name = "����� \"�������\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "��������, ��� \"���������\", �������",
            //                Price = 780,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� � ����������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "���� ������, ��������� �����, ����������� ����, �������� �����, ��������� ����",
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
            //        Name = "����-�����",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 2),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "����� \"�����������\" � �������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 280,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "�������� \"��-���������\" � ����������",
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
            //        Name = "���������",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "����� \"����������\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 340,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� \"�������\"",
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
            //        Name = "������",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 4),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "������-��� � �������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 330,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "������� ������",
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
            //                Name = "����� �� ������ ������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 310,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� \"������\" � ������ �� ������",
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
            //        Name = "��������",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 6),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "����� \"���������\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 500,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� \"����-�����\"",
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
            //                Name = "����� �� �������� ������� ������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 760,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� ������ �� �������� �������",
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
            //        Name = "���� �����",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 1),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "����� \"���������\"",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
            //                Description = "",
            //                Price = 500,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� \"������\"",
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
            //        Name = "��������",
            //        Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
            //        Products = new List<Product>()
            //        {
            //            new Product
            //            {
            //                Name = "����� �� �������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
            //                Description = "",
            //                Price = 650,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����� \"���������\"",
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
            //                Name = "����������� ������",
            //                Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
            //                Description = "",
            //                Price = 750,
            //                LogoPath = ""
            //            },

            //            new Product
            //            {
            //                Name = "����������� ������ � �������",
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
            //        Name = "�����"
            //    },

            //    new ProductType
            //    {
            //        Name = "�������"
            //    },

            //    new ProductType
            //    {
            //        Name = "���� � �����"
            //    },

            //    new ProductType
            //    {
            //        Name = "����"
            //    },

            //    new ProductType
            //    {
            //        Name = "�������"
            //    },

            //    new ProductType
            //    {
            //        Name = "�������"
            //    },

            //    new ProductType
            //    {
            //        Name = "������"
            //    },

            //    new ProductType
            //    {
            //        Name = "����"
            //    },

            //    new ProductType
            //    {
            //        Name = "�������"
            //    },

            //    new ProductType
            //    {
            //        Name = "�������"
            //    },

            //    new ProductType
            //    {
            //        Name = "�������"
            //    },
            //};

            //context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            //context.Shops.AddOrUpdate(s => s.Name, shops);
            //context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);
        }
    }
}
