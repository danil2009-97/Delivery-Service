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
            ShopType[] shopTypes =
            {
                new ShopType
                {
                    Name = "�����������"
                },

                new ShopType
                {
                    Name = "�������"
                },

                new ShopType
                {
                    Name = "����������"
                },

                new ShopType
                {
                    Name = "��������"
                },

                new ShopType
                {
                    Name = "������������"
                },

                new ShopType
                {
                    Name = "������������"
                },

                new ShopType
                {
                    Name = "�����������"
                },
            };

            Shop[] shops =
            {
                new Shop
                {
                    Name = "La Provincia",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 1),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����� \"�������\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "��������, ��� \"���������\", �������",
                            Price = 780,
                            LogoPath = "/Images/1.jpg"
                        },

                        new Product
                        {
                            Name = "����� � ����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "���� ������, ��������� �����, ����������� ����, �������� �����, ��������� ����",
                            Price = 920,
                            LogoPath = "/Images/2.jpg"
                        },

                        new Product
                        {
                            Name = "������ �� ������ � �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "������������ �������� ���� ����������� ����� �� ���������� ������� ������, ������������� ����� � ������� ����",
                            Price = 780,
                            LogoPath = "/Images/3.jpg"
                        },

                        new Product
                        {
                            Name = "��� �������� � ���������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "�������� � ��������� ������",
                            Price = 660,
                            LogoPath = "/Images/4.jpg"
                        },

                        new Product
                        {
                            Name = "��� �� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "������ �������, ���������, �������� �����, ������",
                            Price = 600,
                            LogoPath = "/Images/5.jpg"
                        },

                        new Product
                        {
                            Name = "����� ������ �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "���������� � ������ ������� � ��������� �����",
                            Price = 740,
                            LogoPath = "/Images/6.jpg"
                        },

                        new Product
                        {
                            Name = "������� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "����� ����������� �����, ����������� �������������� �� ������ ������� ��� ����� ���������� �� ������ ������� �� ������ ���� � ������ ������, �������� ������ ��������",
                            Price = 690,
                            LogoPath = "/Images/7.jpg"
                        },

                        new Product
                        {
                            Name = "������� �� ������ ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "������� � ������������ ����, ������ ����������, ������ ���",
                            Price = 1150,
                            LogoPath = "/Images/8.jpg"
                        },

                        new Product
                        {
                            Name = "����� ����� �� ������� ��������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "��������� �������� ����� ����� ������� ��������� ������ �����������",
                            Price = 1440,
                            LogoPath = "/Images/9.jpg"
                        },

                        new Product
                        {
                            Name = "���������� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "���������� ����������� ��������� �����, ���� �� ����������� ����������� �����",
                            Price = 380,
                            LogoPath = "/Images/10.jpg"
                        },

                        new Product
                        {
                            Name = "������� �� ������ ���������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "����� ����������� � ������������ �����, �������������� ����� �������������� ������ �� ��������� ��������� �� ��������� �����",
                            Price = 420,
                            LogoPath = "/Images/11.jpg"
                        },

                        new Product
                        {
                            Name = "������� � ����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
                            Description = "��������� �����, ����, ��������",
                            Price = 180,
                            LogoPath = "/Images/12.jpg"
                        },

                        new Product
                        {
                            Name = "����� ���������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
                            Description = "�������, ������� ���, �����, ����������, ��� ��������, �����",
                            Price = 680,
                            LogoPath = "/Images/13.jpg"
                        },

                        new Product
                        {
                            Name = "������ �� ���������� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "������� ����",
                            Price = 780,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "��� ������� ���� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "���������� (�������)",
                            Price = 12000,
                            LogoPath = "/Images/drinks.png"
                        }
                    },
                    Rating = 4.5,
                    AvgCheck = 5000,
                    LogoPath = "/Images/1.jpg"
                },

                new Shop
                {
                    Name = "����-�����",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 2),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����� \"�����������\" � �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "�������� � ������� ����� �� ������ ������ - ������� �������, ������ ��������� � �������� �������� �����",
                            Price = 280,
                            LogoPath = "/Images/14.jpg"
                        },

                        new Product
                        {
                            Name = "�������� \"��-���������\" � ����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������ ������ ������ ������, ��������� ��������, ����������� ����, �������� ����� � ��� ��������",
                            Price = 160,
                            LogoPath = "/Images/15.jpg"
                        },

                        new Product
                        {
                            Name = "�������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "�������� ������� � ������� ��������� - � �����, � ������� � �����, � �������� � �����, � �������� � �������",
                            Price = 28,
                            LogoPath = "/Images/16.jpg"
                        },

                        new Product
                        {
                            Name = "�������� ��������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "������������ �������� �� ����� ���� � �������-���������� ��������",
                            Price = 140,
                            LogoPath = "/Images/17.jpg"
                        },

                        new Product
                        {
                            Name = "���� ���������� � ��������� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "������ ���� �� ����������� ����� � ����������, ������ ���������� ���� � ���������� ��������� �������, ���������� �������",
                            Price = 150,
                            LogoPath = "/Images/18.jpg"
                        },

                        new Product
                        {
                            Name = "��� �������� ������/�������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "������������ ��������� ���",
                            Price = 125,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "���� ����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "��������� �������  ��������� ����-�����! ������� ���������� ���������� ���� � �������",
                            Price = 205,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "������� ������ � ���������� ������",
                            Price = 50,
                            LogoPath = "/Images/19.jpg"
                        },

                        new Product
                        {
                            Name = "������������ ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "����������� ���� �� ���������, ���������� � �������",
                            Price = 70,
                            LogoPath = "/Images/20.jpg"
                        },

                        new Product
                        {
                            Name = "���� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                            Description = "������������ ������������ �������� ��������������� �������, �������������� �� �������, ��� � ������� � ���� �� �����",
                            Price = 420,
                            LogoPath = "/Images/21.jpg"
                        },

                        new Product
                        {
                            Name = "������� �� �����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                            Description = "������������ � ������� � ������ ������ �����, �������� �� �����. �������� � ������ ��������",
                            Price = 275,
                            LogoPath = "/Images/22.jpg"
                        },

                        new Product
                        {
                            Name = "����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "��������� ������� ����. �������� �� �������� ��� ��������� �� ��� �����",
                            Price = 155,
                            LogoPath = "/Images/23.jpg"
                        },

                        new Product
                        {
                            Name = "����� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "���������� ��� � ������ ������ � �������� ��������",
                            Price = 195,
                            LogoPath = "/Images/24.jpg"
                        },

                        new Product
                        {
                            Name = "��� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "������� ���� � ��������� ���������, ���������� �� ������� �� ����������� �����. ������� � ������ ������",
                            Price = 85,
                            LogoPath = "/Images/25.jpg"
                        },
                    },
                    Rating = 4.3,
                    AvgCheck = 500,
                    LogoPath = "/Images/14.jpg"
                },

                new Shop
                {
                    Name = "���������",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����� \"����������\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "C ������������ ������� �������, �������� � ����������� ��� ������-��������� ���������",
                            Price = 340,
                            LogoPath = "/Images/26.jpg"
                        },

                        new Product
                        {
                            Name = "����� \"�������\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������� ����, ������, ��� ��������, ������ ������ � �������-������ ������",
                            Price = 360,
                            LogoPath = "/Images/27.jpg"
                        },

                        new Product
                        {
                            Name = "��������� ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "���������-��������� ���� � �������� ������� � ��������� �����",
                            Price = 290,
                            LogoPath = "/Images/28.jpg"
                        },

                        new Product
                        {
                            Name = "���������� ��������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "��������� ���������� ������� � �������� �� ������� ��������. �������� � ������� ���������� �����������",
                            Price = 280,
                            LogoPath = "/Images/29.jpg"
                        },

                        new Product
                        {
                            Name = "������� �������� �� �����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "������� �������� �������������� �� ����",
                            Price = 180,
                            LogoPath = "/Images/30.jpg"
                        },

                        new Product
                        {
                            Name = "������ �� �������� �����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                            Description = "�������� � ���������� �� ������ � ������� � �����",
                            Price = 550,
                            LogoPath = "/Images/31.jpg"
                        },

                        new Product
                        {
                            Name = "������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "���������� �������� ����� � ���������, �������� � �������, �������� � ������ ����",
                            Price = 360,
                            LogoPath = "/Images/32.jpg"
                        },

                        new Product
                        {
                            Name = "�������� ��-��������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "�������� ����� �� �������� ����� � �������� �� ������������� ���� � �������� �� ������ ���������� ������ �������",
                            Price = 400,
                            LogoPath = "/Images/33.jpg"
                        },

                        new Product
                        {
                            Name = "������� �� ������ �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "��������, �������, ��������, ������� ����",
                            Price = 980,
                            LogoPath = "/Images/34.jpg"
                        },

                        new Product
                        {
                            Name = "���� ���������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "�������� ��������� ��������������� ����",
                            Price = 329,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "���� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "���������� ������� �����",
                            Price = 400,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "������ �� �������� � �������� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "�������� �� ������ ������ ����",
                            Price = 330,
                            LogoPath = "/Images/35.jpg"
                        },

                        new Product
                        {
                            Name = "������ �� ��������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "������ ������� ������� ���������� �� �����",
                            Price = 650,
                            LogoPath = "/Images/36.jpg"
                        },

                        new Product
                        {
                            Name = "����� ������� � �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "������������ ���������� �����",
                            Price = 475,
                            LogoPath = "/Images/37.jpg"
                        },

                        new Product
                        {
                            Name = "����� ���������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������������ ���������������� ��������� ����� ��������� � ������� �����, ������ � ��������� ������",
                            Price = 330,
                            LogoPath = "/Images/38.jpg"
                        }
                    },
                    Rating = 4.9,
                    AvgCheck = 2000,
                    LogoPath = "/Images/24.jpg"
                },

                new Shop
                {
                    Name = "������",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 4),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "������-��� � �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������ � �����, � ������� ������� � ������ ��������",
                            Price = 330,
                            LogoPath = "/Images/39.jpg"
                        },

                        new Product
                        {
                            Name = "������� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "���� �����, ������� ���� � ���������� � ������",
                            Price = 370,
                            LogoPath = "/Images/1.jpg"
                        },

                        new Product
                        {
                            Name = "���� ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "��� � ����, �������, �������, ���������� ������",
                            Price = 330,
                            LogoPath = "/Images/2.jpg"
                        },

                        new Product
                        {
                            Name = "��� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "������ �����, ��������� ������, �������� ����, ���������� ����",
                            Price = 230,
                            LogoPath = "/Images/3.jpg"
                        },

                        new Product
                        {
                            Name = "��������-����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "��������� �������",
                            Price = 490,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "�������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "�������� ����� �� ����",
                            Price = 595,
                            LogoPath = "/Images/4.jpg"
                        },

                        new Product
                        {
                            Name = "���� ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "� ��������, �������, �������, ����� ������ � ��������� ������",
                            Price = 245,
                            LogoPath = "/Images/5.jpg"
                        },

                        new Product
                        {
                            Name = "������ ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� ������������, �������, ��������, �������, ���������� ������",
                            Price = 395,
                            LogoPath = "/Images/6.jpg"
                        },

                        new Product
                        {
                            Name = "���� ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� �������� �������, �������� ����, �������, �������, ������ �����, ������, ������ �����",
                            Price = 280,
                            LogoPath = "/Images/7.jpg"
                        },

                        new Product
                        {
                            Name = "�����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� �������, �������, �������, ������ �����, �������� � ������ �����",
                            Price = 405,
                            LogoPath = "/Images/8.jpg"
                        },

                        new Product
                        {
                            Name = "���� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� �������, ��������� �������, �������, ������ � ������",
                            Price = 375,
                            LogoPath = "/Images/9.jpg"
                        },

                        new Product
                        {
                            Name = "����� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� ����, �������, �������, �������, ������ ����� � ��������",
                            Price = 395,
                            LogoPath = "/Images/10.jpg"
                        },

                        new Product
                        {
                            Name = "����� ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� ������� ����� ������, �������, ������ � ��������",
                            Price = 210,
                            LogoPath = "/Images/11.jpg"
                        },

                        new Product
                        {
                            Name = "������ �����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "���� �����, ������� ���� � ���������� � ������",
                            Price = 370,
                            LogoPath = "/Images/12.jpg"
                        },

                        new Product
                        {
                            Name = "��� ����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "� ���������, ��������, �������, ������� � ���� ��������� ������",
                            Price = 370,
                            LogoPath = "/Images/13.jpg"
                        }
                    },
                    Rating = 4.4,
                    AvgCheck = 950,
                    LogoPath = "/Images/34.jpg"
                },

                new Shop
                {
                    Name = "Frendy's",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 5),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����� �� ������ ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������ ������ �������� ������, ��������� ����� �����, ������������ ������ ��������. ���������� ���������� ���������� �������� � ����� ����� ��������",
                            Price = 310,
                            LogoPath = "/Images/14.jpg"
                        },

                        new Product
                        {
                            Name = "����� ������ � ������ �� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������ ������ �������� ������, ��������� ����� �����, ������������ ������ ��������. ���������� ���������� ���������� �������� � ����� ����� ��������",
                            Price = 470,
                            LogoPath = "/Images/15.jpg"
                        },

                        new Product
                        {
                            Name = "������������ ��� ��-����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "���������� ������������ ����-��� � ����� ����� � ������� �� ������. �������� � ������� ������ ������",
                            Price = 280,
                            LogoPath = "/Images/16.jpg"
                        },

                        new Product
                        {
                            Name = "��� ����������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "˸���� ������� ���, ������������ ������ ��������� � ���������� ����������� ����������� �������. ������� � ������������ ������� �� ������ �����",
                            Price = 220,
                            LogoPath = "/Images/17.jpg"
                        },

                        new Product
                        {
                            Name = "������� ������� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "������������ ������� �������, ���������� �� ������� � ������������� ������ �������. �������� �� ��������� ������ ������",
                            Price = 320,
                            LogoPath = "/Images/18.jpg"
                        },

                        new Product
                        {
                            Name = "�����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "������� ������ ����� � ���������, �������� � ������� ������� �� ���������� ������, ��������� �������� ��������, �����, ����������� ������� ����������, ���������, ������������� ����� ������, ������ ������ � ���������",
                            Price = 490,
                            LogoPath = "/Images/19.jpg"
                        },

                        new Product
                        {
                            Name = "������ ����� BBQ ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "�������� ��������� ������� ������� � ���������, ������� BBQ ������, ������������� ������ ������������ �����, �������� ������, ����������, ������������ ������� � ������ �����. ������� � ���������� ��� � ������� ����-���",
                            Price = 510,
                            LogoPath = "/Images/20.jpg"
                        },

                        new Product
                        {
                            Name = "������ ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "�������� �������� ���������� ������������ ������, ������������� ����������� �����, ��������� ������ ������ ������, �������� ������, ����������, ����� � ������������ �������. ������� � ���������� ��� � ������� ����-���",
                            Price = 490,
                            LogoPath = "/Images/21.jpg"
                        },

                        new Product
                        {
                            Name = "������ �� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "������ � ����������� ����� � ������� ��������, ����� ��������� � ������� ��������. �������� � ��������� ��-���������� ���������� � ��������-��������� �����",
                            Price = 450,
                            LogoPath = "/Images/22.jpg"
                        },

                        new Product
                        {
                            Name = "����� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "���������� �������� �� ������� �������� ������, ������������� ����� ������ � ����������� �� ����� ������� ����������, ����� � ��������� �������. �������� � ���������� ��� � ������� ����-���",
                            Price = 390,
                            LogoPath = "/Images/23.jpg"
                        },

                        new Product
                        {
                            Name = "������ ����� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "�������� ���������� �������� ������������ ������ �� ������������� ���� ������, �������� ������, ����������, ����� � ������������ �������",
                            Price = 550,
                            LogoPath = "/Images/24.jpg"
                        },

                        new Product
                        {
                            Name = "������ �����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "���������� ���������� ������ � ������� � ������� ���������� ����������, ������� ���������� �������",
                            Price = 290,
                            LogoPath = "/Images/25.jpg"
                        },

                        new Product
                        {
                            Name = "���������� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "��������� �������",
                            Price = 310,
                            LogoPath = "/Images/26.jpg"
                        },

                        new Product
                        {
                            Name = "Evian (��� ����)",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "����������� ����, 330 ��",
                            Price = 140,
                            LogoPath = "/Images/27.jpg"
                        },

                        new Product
                        {
                            Name = "�������� �����",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "�������� �������� ����� � ������� ���������� ���������� � �������� ��������",
                            Price = 310,
                            LogoPath = "/Images/28.jpg"
                        }
                    },
                    Rating = 4.65,
                    AvgCheck = 1200,
                    LogoPath = "/Images/z.jpg"
                },

                new Shop
                {
                    Name = "��������",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 6),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����� \"���������\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "������������ ����� ����-������, ��������, ��������, ��������� � ������ �������, ����������, ����� � ��������� �����",
                            Price = 500,
                            LogoPath = "/Images/29.jpg"
                        },

                        new Product
                        {
                            Name = "����� \"����-�����\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "�������� ��������� �������� � ��������, ������, �����, ��������, �������, �������� ������������ � �������� ����� � ����� ������ ������",
                            Price = 460,
                            LogoPath = "/Images/30.jpg"
                        }
                    },
                    Rating = 3.7,
                    AvgCheck = 1250,
                    LogoPath = ""
                },

                new Shop
                {
                    Name = "��������",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����� �� �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "����� �� ������� � ������������ ����������, ������� ����� � �������� �����",
                            Price = 650,
                            LogoPath = "/Images/31.jpg"
                        },

                        new Product
                        {
                            Name = "����� \"���������\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "����� �� ������, ������ � ��������",
                            Price = 310,
                            LogoPath = "/Images/32.jpg"
                        }
                    },
                    Rating = 4.3,
                    AvgCheck = 1750,
                    LogoPath = ""
                },

                new Shop
                {
                    Name = "Hard Rock Cafe",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 5),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "����������� ������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "���������� �� ���� ���� ������ � �������� �������",
                            Price = 750,
                            LogoPath = "/Images/33.jpg"
                        },

                        new Product
                        {
                            Name = "����������� ������ � �������",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "������� ������ � ����������� ���������� � ����� ��������� ������������ ����",
                            Price = 775,
                            LogoPath = "/Images/34.jpg"
                        }
                    },
                    Rating = 4.9,
                    AvgCheck = 1400,
                    LogoPath = ""
                },

            new Shop
            {
                Name = "���� �����",
                Type = context.ShopTypes.FirstOrDefault(s => s.Id == 1),
                Rating = 4.2,
                AvgCheck = 750,
                Products = new List<Product>(),
                LogoPath = "/Images/v.jpg",
{
new Product
{
Name = "����� ���������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, ��� ���������, ������, �������",
Price = 690,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "����� ������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������, ���������, �������� � �����",
Price = 800,
LogoPath = "/Images/21.jpg"
},
new Product
{
Name = "����� ����� �����",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� ����� ���� �����, ���� �����-������� ����, ������� ���� � ��������� �������, ���, ������� ������ �����, ������� ������� �����, �������, ��� ���������",
Price = 800,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "����� ���������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, ���������, ��� ���������",
Price = 810,
LogoPath = "/Images/21.jpg"
},
new Product
{
Name = "����� ���������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, �������, �������. ��� ���������",
Price = 780,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "����� ������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, ��� ���������",
Price = 760,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "����� ��������������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, ������, ����������, ���, ������� ������� �����, ������ ������, ��� ���������",
Price = 820,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "����� ��������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "�������, �����, ������, ����������, ���� ���������, ��� ���������",
Price = 820,
LogoPath = "/Images/21.jpg"
},
new Product
{
Name = "����� ��������� ������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, ���������, ��������� �������, �������, ����������, ������ ������, ��� ���������",
Price = 760,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "����� ������������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "��������� �������� ���� ���� �����, ������� ������, ������� ������� �����, ���, ����������, ������, ����� ���������, ��� ���������",
Price = 790,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "��������� ����",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
Description = "��������� ����� ���� �����, ���� ��������� ����, ���������, ��� ���������, ��� ���������",
Price = 400,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "����� ������ � ������",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
Description = "����� ������� (������, �������, ����� �����, �������, �������), ����� ����������������, ������ �����, ���� �������, �������, �������, ����� �������",
Price = 560,
LogoPath = "/Images/21.jpg"
}
}
            },
            new Shop
            {
                Name = "Chateau de Fleurs",
                Type = context.ShopTypes.FirstOrDefault(s => s.Id == 7),
                Rating = 5,
                AvgCheck = 5000,
                LogoPath = "/Images/y.jpg",
                Products = new List<Product>()
                        {
                        new Product
                        {
                        Name = "����� ������ �� �������� �������",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
                        Description = "�������������� �� ������ ������������ �� ������ ��������� Felinese, ������ �� �����������, ����������� ������������ � �������� ���������� ����������. ����������� ������ ������ ���-��",
                        Price = 960,
                        LogoPath = "/Images/1.jpg"
                        },
                        new Product
                        {
                        Name = "����� �� �������� ������� ������",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                        Description = "������������ � ����� � �������, � ��������� � �������� ��������, �������� ���������, �������� ������� ������ � ������� �� ����� ������",
                        Price = 760,
                        LogoPath = "/Images/2.jpg"
                        },
                        new Product
                        {
                        Name = "����������� ������",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                        Description = "� ������� �� ������ ������ � ������� �������. �������� � ������ ����������� �������",
                        Price = 960,
                        LogoPath = "/Images/3.jpg"
                        },
                        new Product
                        {
                        Name = "������������ ����� Caesar",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                        Description = "� ������ ������� ���� � ����� �������, ��������� � ������� �������� ������ � �������� ������ Caesar. ����������� �������� ������������ ������",
                        Price = 780,
                        LogoPath = "/Images/4.jpg"
                        },
                        new Product
                        {
                        Name = "�������� ������ Serrano",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                        Description = "� ������ �������, ��������� ����� Mascarpone � ���������� ��������",
                        Price = 810,
                        LogoPath = "/Images/7.jpg"
                        },
                        new Product
                        {
                        Name = "����������, ���������� � �������� �������� �����",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                        Description = "� �������� �����, ��������� � ������ ������ � ������ Namekko",
                        Price = 520,
                        LogoPath = "/Images/11.jpg"
                        },
                        new Product
                        {
                        Name = "�������� ������� � ��������� St. Jaques",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                        Description = "��������� �������� �������, ������� ����������, ��������� ������� � ����������� ����� ������",
                        Price = 890,
                        LogoPath = "/Images/13.jpg"
                        },
                        new Product
                        {
                        Name = "����������������� ���",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                        Description = "�� ��������� ������� Beef, c �������� �������, �����������, ������� ��������� St. Ja�ques, ���������� �������, ��������� ���������� � Casule �� ����� ���",
                        Price = 810,
                        LogoPath = "/Images/8.jpg"
                        },
                        new Product
                        {
                        Name = "Consomme",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                        Description = "������� ������, � ����������� ��������������� ����� ��������� � �������. �������� � ���������������� ������� ���������",
                        Price = 810,
                        LogoPath = "/Images/9.jpg"
                        },

                        new Product
                        {
                        Name = "����� �� ��������� ����� Wagyu",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                        Description = "������� ����������� 4-5. ����������� �� ����������� ����� � ������ �� ��������. ����������� ����-�������",
                        Price = 3300,
                        LogoPath = "/Images/7.jpg"
                        },
                        new Product
                        {
                        Name = "����� �������",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                        Description = "������� ����� ������ ������",
                        Price = 810,
                        LogoPath = "/Images/16.jpg"
                        },
                        new Product
                        {
                        Name = "Casanova di Neri, Brunello di Montalcino",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                        Description = "������� ����� ����, ������ 1996",
                        Price = 5500,
                        LogoPath = "/Images/drinks.png"
                        },
                        new Product
                        {
                        Name = "Chateau d'Armailhac Grand Cru Classe",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                        Description = "����� ��������� ����, ������ 2001",
                        Price = 11500,
                        LogoPath = "/Images/drinks.png"
}
} } };


            ProductType[] productTypes =
            {
                new ProductType
                {
                    Name = "�����"
                },

                new ProductType
                {
                    Name = "�������"
                },

                new ProductType
                {
                    Name = "���� � �����"
                },

                new ProductType
                {
                    Name = "����"
                },

                new ProductType
                {
                    Name = "�������"
                },

                new ProductType
                {
                    Name = "�������"
                },

                new ProductType
                {
                    Name = "������"
                },

                new ProductType
                {
                    Name = "����"
                },

                new ProductType
                {
                    Name = "�������"
                },

                new ProductType
                {
                    Name = "�������"
                },

                new ProductType
                {
                    Name = "�������"
                },
            };

            context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            //context.Shops.AddOrUpdate(s => s.Name, shops);
            context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);
        }
    }
}
