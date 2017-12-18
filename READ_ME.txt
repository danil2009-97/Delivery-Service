+<--- Food Delivery Service Application --->

Чтобы успешно запустить проект, необходимо дважды вызвать команду Update-Database в Диспетчере Пакетов. В конце тела метода Seed() при первом апдейте БД прописать:

 	   context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            
	 //context.Shops.AddOrUpdate(s => s.Name, shops);
            
	   context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);

При втором апдейте БД:

         //context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            
	   context.Shops.AddOrUpdate(s => s.Name, shops);
            
	 //context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);

После этих действий БД будет полностью сформирована, и проект будет работать нормально.