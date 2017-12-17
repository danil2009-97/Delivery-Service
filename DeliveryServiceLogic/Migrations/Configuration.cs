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
                    Name = "Итальянская"
                },

                new ShopType
                {
                    Name = "Русская"
                },

                new ShopType
                {
                    Name = "Кавказская"
                },

                new ShopType
                {
                    Name = "Японская"
                },

                new ShopType
                {
                    Name = "Американская"
                },

                new ShopType
                {
                    Name = "Мексиканская"
                },

                new ShopType
                {
                    Name = "Французская"
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
                            Name = "Салат \"Капрезе\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Помидоры, сыр \"Моцарелла\", базилик",
                            Price = 780,
                            LogoPath = "/Images/1.jpg"
                        },

                        new Product
                        {
                            Name = "Салат с перепелами",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Микс салата, перепелка гриль, перепелиное яйцо, помидоры черри, пикантный соус",
                            Price = 920,
                            LogoPath = "/Images/2.jpg"
                        },

                        new Product
                        {
                            Name = "Тартар из лосося с авокадо",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Классический холодный соус французской кухни из сваренного вкрутую желтка, растительного масла и зелёного лука",
                            Price = 780,
                            LogoPath = "/Images/3.jpg"
                        },

                        new Product
                        {
                            Name = "Сыр Камамбер в панировке",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Подается с малиновым соусом",
                            Price = 660,
                            LogoPath = "/Images/4.jpg"
                        },

                        new Product
                        {
                            Name = "Суп из ягненка",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Мякоть ягненка, картофель, помидоры черри, цукини",
                            Price = 600,
                            LogoPath = "/Images/5.jpg"
                        },

                        new Product
                        {
                            Name = "Паста белыми грибами",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Тальятелле с белыми грибами в сливочном соусе",
                            Price = 740,
                            LogoPath = "/Images/6.jpg"
                        },

                        new Product
                        {
                            Name = "Лазанья мясная",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Блюдо итальянской кухни, традиционно приготовляемое из листов лазанья аль форно вперемешку со слоями начинки на основе рагу с мясным фаршем, залитого соусом бешамель",
                            Price = 690,
                            LogoPath = "/Images/7.jpg"
                        },

                        new Product
                        {
                            Name = "Котлета из дикого кабана",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Подаётся с картофельным пюре, свекла запеченная, томаты биф",
                            Price = 1150,
                            LogoPath = "/Images/8.jpg"
                        },

                        new Product
                        {
                            Name = "Стейк Ангус из вырезки говядины",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Мраморную говядину смело можно назвать королевой мясных деликатесов",
                            Price = 1440,
                            LogoPath = "/Images/9.jpg"
                        },

                        new Product
                        {
                            Name = "Шоколадный фондан",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Популярное французское десертное блюдо, кекс из шоколадного бисквитного теста",
                            Price = 380,
                            LogoPath = "/Images/10.jpg"
                        },

                        new Product
                        {
                            Name = "Чизкейк со свежей клубникой",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Блюдо европейской и американской кухни, представляющее собой сыросодержащий десерт от творожной запеканки до пирожного суфле",
                            Price = 420,
                            LogoPath = "/Images/11.jpg"
                        },

                        new Product
                        {
                            Name = "Фокачча с пармезаном",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
                            Description = "Оливковое масло, соль, пармезан",
                            Price = 180,
                            LogoPath = "/Images/12.jpg"
                        },

                        new Product
                        {
                            Name = "Пицца Баварская",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
                            Description = "Сметана, зеленый лук, бекон, шампиньоны, сыр Пармезан, укроп",
                            Price = 680,
                            LogoPath = "/Images/13.jpg"
                        },

                        new Product
                        {
                            Name = "Маркес де Альдэнуэва Крианса",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Красное вино",
                            Price = 780,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "Луи Родерер Брют Премье",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Шампанское (бутылка)",
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
                    Name = "Елки-Палки",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 2),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "Салат \"Итальянский\" с лососем",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Полезный и вкусный салат из свежих овощей - кусочки огурцов, дольки помидоров и цветного сладкого перца",
                            Price = 280,
                            LogoPath = "/Images/14.jpg"
                        },

                        new Product
                        {
                            Name = "Винегрет \"По-домашнему\" с селедочкой",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Сочные листья салата Романо, пшеничные сухарики, перепелиные яйца, помидоры Черри и сыр Пармезан",
                            Price = 160,
                            LogoPath = "/Images/15.jpg"
                        },

                        new Product
                        {
                            Name = "Пирожки",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "Домашние пирожки с разными начинками - с мясом, с грибами и луком, с капустой и яйцом, с яблоками и сахаром",
                            Price = 28,
                            LogoPath = "/Images/16.jpg"
                        },

                        new Product
                        {
                            Name = "Штрудель яблочный",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "Классический штрудель из теста фило с яблочно-миндальной начинкой",
                            Price = 140,
                            LogoPath = "/Images/17.jpg"
                        },

                        new Product
                        {
                            Name = "Торт шоколадный с хрустящим пралине",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Тонкий слой из шоколадного теста с марципаном, густой шоколадный мусс с хрустящими кусочками пралине, шоколадная глазурь",
                            Price = 150,
                            LogoPath = "/Images/18.jpg"
                        },

                        new Product
                        {
                            Name = "Чай листовой чёрный/зеленый",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Классический целонский чай",
                            Price = 125,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "Морс клюквенный",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Фирменный напиток  трактиров Ёлки-Палки! Вкусный освежающий клюквенный морс с мякотью",
                            Price = 205,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "Гречка",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Вареная гречка с обжаренным лучком",
                            Price = 50,
                            LogoPath = "/Images/19.jpg"
                        },

                        new Product
                        {
                            Name = "Картофельное пюре",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Натуральное пюре из картофеля, толченного с молоком",
                            Price = 70,
                            LogoPath = "/Images/20.jpg"
                        },

                        new Product
                        {
                            Name = "Каре ягненка",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                            Description = "Классические маринованные ребрышки новозеландского ягненка, приготовленные на мангале, рис с овощами и соус на выбор",
                            Price = 420,
                            LogoPath = "/Images/21.jpg"
                        },

                        new Product
                        {
                            Name = "Свинина на гриле",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                            Description = "Маринованная в специях и зелени свиная шейка, жаренная на гриле. Подается с соусом Сацибели",
                            Price = 275,
                            LogoPath = "/Images/22.jpg"
                        },

                        new Product
                        {
                            Name = "Борщ",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Настоящий русский борщ. Подается со сметаной или майонезом на ваш выбор",
                            Price = 155,
                            LogoPath = "/Images/23.jpg"
                        },

                        new Product
                        {
                            Name = "Лапша куриная",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Наваристый суп с яичной лапшой и куриными грудками",
                            Price = 195,
                            LogoPath = "/Images/24.jpg"
                        },

                        new Product
                        {
                            Name = "Сыр жареный",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Кусочки сыра в бархатной панировке, обжаренные во фритюре до золотистого цвета. Подаётся с пряным соусом",
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
                    Name = "ДжонДжоли",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "Салат \"Багратиони\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "C подкопченной куриной грудкой, томатами и апельсинами под медово-горчичной заправкой",
                            Price = 340,
                            LogoPath = "/Images/26.jpg"
                        },

                        new Product
                        {
                            Name = "Салат \"Цезария\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Куриное филе, томаты, сыр Сулугуни, листья салата с орехово-сырным соусом",
                            Price = 360,
                            LogoPath = "/Images/27.jpg"
                        },

                        new Product
                        {
                            Name = "Морковный торт",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Бисквитно-морковный торт с грецкими орехами и сливочным сыром",
                            Price = 290,
                            LogoPath = "/Images/28.jpg"
                        },

                        new Product
                        {
                            Name = "Шоколадная шкатулка",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Воздушный шоколадный бисквит с начинкой из теплого шоколада. Подается с шариком ванильного мороженного",
                            Price = 280,
                            LogoPath = "/Images/29.jpg"
                        },

                        new Product
                        {
                            Name = "Початок кукурузы на углях",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Молодая кукуруза приготовленная на огне",
                            Price = 180,
                            LogoPath = "/Images/30.jpg"
                        },

                        new Product
                        {
                            Name = "Шашлык из куриного бедра",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                            Description = "Подается с рулетиками из лаваша с зеленью и сыром",
                            Price = 550,
                            LogoPath = "/Images/31.jpg"
                        },

                        new Product
                        {
                            Name = "Каурма",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                            Description = "Обжаренная домашняя лапша с бараниной, тушенной с овощами, подается с соусом Лаза",
                            Price = 360,
                            LogoPath = "/Images/32.jpg"
                        },

                        new Product
                        {
                            Name = "Хачапури по-аджарски",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "Открытый пирог из сдобного теста с начинкой из Имеретинского сыра и Сулугуни со слегка запеченным яичным желтком",
                            Price = 400,
                            LogoPath = "/Images/33.jpg"
                        },

                        new Product
                        {
                            Name = "Ассорти из мясных закусок",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Говядина, ветчина, буженина, вяленое мясо",
                            Price = 980,
                            LogoPath = "/Images/34.jpg"
                        },

                        new Product
                        {
                            Name = "Пиво Эдельвейс",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Немецкое пшеничное нефильтрованное пиво",
                            Price = 329,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "Пиво Гинесс",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Ирландский элитный стаут",
                            Price = 400,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "Лагман из баранины с домашней лапшой",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Подается со жгучим соусом Лаза",
                            Price = 330,
                            LogoPath = "/Images/35.jpg"
                        },

                        new Product
                        {
                            Name = "Шашлык из телятины",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Нежные кусочки теленка обжаренные на углях",
                            Price = 650,
                            LogoPath = "/Images/36.jpg"
                        },

                        new Product
                        {
                            Name = "Пирог Кудбари с курицей",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "Традиционный осетинский пирог",
                            Price = 475,
                            LogoPath = "/Images/37.jpg"
                        },

                        new Product
                        {
                            Name = "Салат ДжонДжоли",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Маринованные нераспустившиеся цветочные почки джонджоли с красным луком, кинзой и оливковым маслом",
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
                    Name = "Тануки",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 4),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "Цезарь-сан с курицей",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Курица с сыром, с салатом «романо» и соусом «Цезарь»",
                            Price = 330,
                            LogoPath = "/Images/39.jpg"
                        },

                        new Product
                        {
                            Name = "Дайкани сарада",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Мясо краба, снежный краб с апельсином и тобико",
                            Price = 370,
                            LogoPath = "/Images/1.jpg"
                        },

                        new Product
                        {
                            Name = "Сякэ мисо",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Суп с мисо, лососем, грибами, трюфельным маслом",
                            Price = 330,
                            LogoPath = "/Images/2.jpg"
                        },

                        new Product
                        {
                            Name = "Ами суфури",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Нежное суфле, сгущённое молоко, лимонный фреш, шоколадный соус",
                            Price = 230,
                            LogoPath = "/Images/3.jpg"
                        },

                        new Product
                        {
                            Name = "Мандарин-юдзу",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Фирменный лимонад",
                            Price = 490,
                            LogoPath = "/Images/drinks.png"
                        },

                        new Product
                        {
                            Name = "Унайдзю",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Копчёный угорь на рисе",
                            Price = 595,
                            LogoPath = "/Images/4.jpg"
                        },

                        new Product
                        {
                            Name = "Сякэ футо",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "С харумаки, лососем, авокадо, сыром чеддер и сливочным соусом",
                            Price = 245,
                            LogoPath = "/Images/5.jpg"
                        },

                        new Product
                        {
                            Name = "Дорама ролл",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С желтохвостом, авокадо, дайконом, тенкацу, трюфельным соусом",
                            Price = 395,
                            LogoPath = "/Images/6.jpg"
                        },

                        new Product
                        {
                            Name = "Хино ролл",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С опалённым лососем, копчёным угрём, авокадо, тенкацу, мягким сыром, тобико, соусом Унаги",
                            Price = 280,
                            LogoPath = "/Images/7.jpg"
                        },

                        new Product
                        {
                            Name = "Филадельфия",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С лососем, огурцом, авокадо, зелёным луком, кунжутом и мягким сыром",
                            Price = 405,
                            LogoPath = "/Images/8.jpg"
                        },

                        new Product
                        {
                            Name = "Сякэ темпура",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С лососем, креветкой темпура, огурцом, тобико и васаби",
                            Price = 375,
                            LogoPath = "/Images/9.jpg"
                        },

                        new Product
                        {
                            Name = "Унаги урамаки",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С угрём, лососем, авокадо, огурцом, мягким сыром и кунжутом",
                            Price = 395,
                            LogoPath = "/Images/10.jpg"
                        },

                        new Product
                        {
                            Name = "Овара ролл",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С жареной кожей лосося, огурцом, тобико и кунжутом",
                            Price = 210,
                            LogoPath = "/Images/11.jpg"
                        },

                        new Product
                        {
                            Name = "Хотатэ караи",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "Мясо краба, снежный краб с апельсином и тобико",
                            Price = 370,
                            LogoPath = "/Images/12.jpg"
                        },

                        new Product
                        {
                            Name = "Эби грин",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 3),
                            Description = "С креветкой, рукколой, авокадо, огурцом и трио фирменных соусов",
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
                            Name = "Салат из свежих овощей",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Свежие листья зеленого салата, нежнейшая семга гриль, заправленные соусом «Цезарь». Посыпается хрустящими чесночными гренками и тёртым сыром Пармезан",
                            Price = 310,
                            LogoPath = "/Images/14.jpg"
                        },

                        new Product
                        {
                            Name = "Салат Цезарь с семгой на грилле",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Свежие листья зеленого салата, нежнейшая семга гриль, заправленные соусом «Цезарь». Посыпается хрустящими чесночными гренками и тёртым сыром Пармезан",
                            Price = 470,
                            LogoPath = "/Images/15.jpg"
                        },

                        new Product
                        {
                            Name = "Картофельный суп по-деревенски",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Насыщенный картофельный крем-суп с тёртым сыром и чипсами из бекона. Подается с горячим сырным тостом",
                            Price = 280,
                            LogoPath = "/Images/16.jpg"
                        },

                        new Product
                        {
                            Name = "Суп Минестроне",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                            Description = "Лёгкий овощной суп, заправленный соусом “Итальяно” и уникальной комбинацией итальянских приправ. Подаётся с поджаренными тостами из белого хлеба",
                            Price = 220,
                            LogoPath = "/Images/17.jpg"
                        },

                        new Product
                        {
                            Name = "Куриные ломтики Баффало",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Панированные куриные ломтики, обжаренные во фритюре и глазированные соусом Баффало. Подаются со сливочным соусом “Ранч“",
                            Price = 320,
                            LogoPath = "/Images/18.jpg"
                        },

                        new Product
                        {
                            Name = "Начос",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                            Description = "Большая порция “Чили“ с говядиной, свининой и красной фасолью на кукурузных чипсах, аппетитно покрытая сметаной, луком, нарезанными свежими помидорами, маслинами, расплавленным сыром Чеддер, сырным соусом и Халапеньо",
                            Price = 490,
                            LogoPath = "/Images/19.jpg"
                        },

                        new Product
                        {
                            Name = "Кранчи онион BBQ бургер",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Дополнен хрустящим луковым кольцом в панировке, сладким BBQ соусом, расплавленным желтым американским сыром, листьями салата, помидорами, маринованным огурцом и свежим луком. Подаётся с картофелем Фри и салатом Коул-Сло",
                            Price = 510,
                            LogoPath = "/Images/20.jpg"
                        },

                        new Product
                        {
                            Name = "Хикори бургер",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Дополнен слайсами хрустящего поджаренного бекона, расплавленным швейцарским сыром, фирменным дымным соусом Хикори, листьями салата, помидорами, луком и маринованным огурцом. Подаётся с картофелем Фри и салатом Коул-Сло",
                            Price = 490,
                            LogoPath = "/Images/21.jpg"
                        },

                        new Product
                        {
                            Name = "Бургер Ла Капрезе",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Бургер в итальянском стиле с двойной котлетой, сыром Моцарелла и спелыми томатами. Подается с картошкой по-деревенски обжаренной в чесночно-сливочном соусе",
                            Price = 450,
                            LogoPath = "/Images/22.jpg"
                        },

                        new Product
                        {
                            Name = "Гриль бургер",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Аппетитный бифштекс со свежими листьями салата, расплавленным сыром чеддер и обжаренными на гриле спелыми помидорами, луком и ароматным беконом. Подается с картофелем фри и салатом Коул-сло",
                            Price = 390,
                            LogoPath = "/Images/23.jpg"
                        },

                        new Product
                        {
                            Name = "Чеддер Бекон бургер",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Дополнен хрустящими слайсами поджаренного бекона на расплавленном сыре Чеддер, листьями салата, помидорами, луком и маринованным огурцом",
                            Price = 550,
                            LogoPath = "/Images/24.jpg"
                        },

                        new Product
                        {
                            Name = "Брауни Сандэ",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 10),
                            Description = "Насыщенный шоколадный десерт с орехами и шариком ванильного мороженого, политый шоколадным сиропом",
                            Price = 290,
                            LogoPath = "/Images/25.jpg"
                        },

                        new Product
                        {
                            Name = "Английская бузина",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Крафтовый лимонад",
                            Price = 310,
                            LogoPath = "/Images/26.jpg"
                        },

                        new Product
                        {
                            Name = "Evian (без газа)",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                            Description = "Минеральная вода, 330 мл",
                            Price = 140,
                            LogoPath = "/Images/27.jpg"
                        },

                        new Product
                        {
                            Name = "Яблочный пирог",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 11),
                            Description = "Домашний яблочный пирог с шариком ванильного мороженого и взбитыми сливками",
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
                    Name = "Сомбреро",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 6),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "Салат \"Акапулько\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Маринованные мидии киви-гигант, креветки, кальмары, осьминоги с миксом салатов, сельдереем, черри в восточном соусе",
                            Price = 500,
                            LogoPath = "/Images/29.jpg"
                        },

                        new Product
                        {
                            Name = "Салат \"Мачу-пикчу\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Жаренная мраморная говядина с рукколой, романо, черри, огурцами, редисом, Кактусом маринованным в ореховом соусе с сыром «Грано Падано»",
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
                    Name = "Кабанчик",
                    Type = context.ShopTypes.FirstOrDefault(s => s.Id == 3),
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            Name = "Салат из авокадо",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Салат из авокадо с королевскими креветками, красной икрой и крабовым мясом",
                            Price = 650,
                            LogoPath = "/Images/31.jpg"
                        },

                        new Product
                        {
                            Name = "Салат \"Столичный\"",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                            Description = "Салат из овощей, зелени и майонеза",
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
                            Name = "Легендарный бургер",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Знаменитый во всем мире бургер с копченым беконом",
                            Price = 750,
                            LogoPath = "/Images/33.jpg"
                        },

                        new Product
                        {
                            Name = "Швейцарский бургер с грибами",
                            Type = context.ProductTypes.FirstOrDefault(p => p.Id == 2),
                            Description = "Большой бургер с обжаренными грибочками и двумя домтиками Швейцарского сыра",
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
                Name = "Папа Джонс",
                Type = context.ShopTypes.FirstOrDefault(s => s.Id == 1),
                Rating = 4.2,
                AvgCheck = 750,
                Products = new List<Product>(),
                LogoPath = "/Images/v.jpg",
{
new Product
{
Name = "Пицца Маргарита",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, сыр моцарелла, томаты, орегано",
Price = 690,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "Пицца Мясная",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Ароматная свинина, пепперони, говядина и бекон",
Price = 800,
LogoPath = "/Images/21.jpg"
},
new Product
{
Name = "Пицца Чикен Алоха",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменное тесто Папа Джонс, соус кисло-сладкий чили, куриное филе в хрустящей корочке, лук, сладкий зелёный перец, сладкий красный перец, ананасы, сыр Моцарелла",
Price = 800,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "Пицца Пепперони",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, пепперони, сыр моцарелла",
Price = 810,
LogoPath = "/Images/21.jpg"
},
new Product
{
Name = "Пицца Гавайская",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, ветчина, ананасы. сыр моцарелла",
Price = 780,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "Пицца Сырная",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, сыр моцарелла",
Price = 760,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "Пицца Вегетарианская",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, томаты, шампиньоны, лук, сладкий зеленый перец, черные оливки, сыр моцарелла",
Price = 820,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "Пицца Альфредо",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Ветчина, бекон, томаты, шампиньоны, соус Шпинатный, сыр моцарелла",
Price = 820,
LogoPath = "/Images/21.jpg"
},
new Product
{
Name = "Пицца Маленькая Италия",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, пепперони, ароматная свинина, орегано, шампиньоны, черные оливки, сыр моцарелла",
Price = 760,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "Пицца Мексиканская",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
Description = "Фирменный томатный соус Папа Джонс, куриная грудка, сладкий зеленый перец, лук, шампиньоны, томаты, перец халапеньо, сыр моцарелла",
Price = 790,
LogoPath = "/Images/26.jpg"
},
new Product
{
Name = "Пепперони Ролл",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
Description = "Фирменное тесто Папа Джонс, соус Чесночный Ранч, пепперони, сыр Реджанито, сыр Моцарелла",
Price = 400,
LogoPath = "/Images/39.jpg"
},
new Product
{
Name = "Салат Нисуаз с тунцом",
Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
Description = "Смесь салатов (Романо, Руккола, Лолло Россо, Радичио, Айсберг), тунец консервированный, томаты черри, яйцо куриное, маслины, каперсы, перец сладкий",
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
                        Name = "Салат теплый из телячьей вырезки",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 1),
                        Description = "Приготовленной на низких температурах со свиной грудинкой Felinese, пастой из корнеплодов, обжаренными шампиньонами и печеными бакинскими помидорами. Дополняется пряным соусом Ким-чи",
                        Price = 960,
                        LogoPath = "/Images/1.jpg"
                        },
                        new Product
                        {
                        Name = "Салат из томленой гусиной грудки",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                        Description = "Маринованной с медом и имбирем, в сочетании с вялеными яблоками, дольками мандарина, домашним ягодным соусом и чипсами из корня лотоса",
                        Price = 760,
                        LogoPath = "/Images/2.jpg"
                        },
                        new Product
                        {
                        Name = "Бургундские улитки",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                        Description = "С букетом из свежей зелени и вяленых томатов. Подаются с теплым французским багетом",
                        Price = 960,
                        LogoPath = "/Images/3.jpg"
                        },
                        new Product
                        {
                        Name = "Оригинальный салат Caesar",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                        Description = "С теплым куриным филе в соусе Терияки, смешанный с сочными листьями романо и домашним соусом Caesar. Дополняется слайсами французского багета",
                        Price = 780,
                        LogoPath = "/Images/4.jpg"
                        },
                        new Product
                        {
                        Name = "Лепестки хамона Serrano",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 6),
                        Description = "С теплым инжиром, сливочным сыром Mascarpone и пшеничными слайсами",
                        Price = 810,
                        LogoPath = "/Images/7.jpg"
                        },
                        new Product
                        {
                        Name = "Каннеллони, запеченные с домашним молочным сыром",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                        Description = "С томатами черри, томлеными в пряных травах с соусом Namekko",
                        Price = 520,
                        LogoPath = "/Images/11.jpg"
                        },
                        new Product
                        {
                        Name = "Открытые равиоли с гребешком St. Jaques",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 9),
                        Description = "Стручками молодого горошка, пряными артишоками, кенийской фасолью и французским белым соусом",
                        Price = 890,
                        LogoPath = "/Images/13.jpg"
                        },
                        new Product
                        {
                        Name = "Средиземноморский суп",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 7),
                        Description = "Из протертых томатов Beef, c голубыми мидиями, каракатицей, морским гребешком St. Jaсques, норвежским лососем, тигровыми креветками и Casule из белых рыб",
                        Price = 810,
                        LogoPath = "/Images/8.jpg"
                        },
                        new Product
                        {
                        Name = "Consomme",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 8),
                        Description = "Куриный бульон, с добавлением бланшированного корня сельдерея и моркови. Подается с карамелизованным молодым цыпленком",
                        Price = 810,
                        LogoPath = "/Images/9.jpg"
                        },

                        new Product
                        {
                        Name = "Стейк из японского бычка Wagyu",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                        Description = "Степень мраморности 4-5. Сервируется на раскаленном камне с соусом из цитрусов. Дополняется микс-салатом",
                        Price = 3300,
                        LogoPath = "/Images/7.jpg"
                        },
                        new Product
                        {
                        Name = "Дикая оленина",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 4),
                        Description = "Любимое блюдо короля Ренода",
                        Price = 810,
                        LogoPath = "/Images/16.jpg"
                        },
                        new Product
                        {
                        Name = "Casanova di Neri, Brunello di Montalcino",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                        Description = "Красное сухое вино, урожай 1996",
                        Price = 5500,
                        LogoPath = "/Images/drinks.png"
                        },
                        new Product
                        {
                        Name = "Chateau d'Armailhac Grand Cru Classe",
                        Type = context.ProductTypes.FirstOrDefault(p => p.Id == 5),
                        Description = "Белое полусухое вино, урожай 2001",
                        Price = 11500,
                        LogoPath = "/Images/drinks.png"
}
} } };


            ProductType[] productTypes =
            {
                new ProductType
                {
                    Name = "Пицца"
                },

                new ProductType
                {
                    Name = "Бургеры"
                },

                new ProductType
                {
                    Name = "Суши и роллы"
                },

                new ProductType
                {
                    Name = "Мясо"
                },

                new ProductType
                {
                    Name = "Напитки"
                },

                new ProductType
                {
                    Name = "Закуски"
                },

                new ProductType
                {
                    Name = "Салаты"
                },

                new ProductType
                {
                    Name = "Супы"
                },

                new ProductType
                {
                    Name = "Гарниры"
                },

                new ProductType
                {
                    Name = "Десерты"
                },

                new ProductType
                {
                    Name = "Выпечка"
                },
            };

            context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            //context.Shops.AddOrUpdate(s => s.Name, shops);
            context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);
        }
    }
}
