+<--- Food Delivery Service Application --->

����� ������� ��������� ������, ���������� ������ ������� ������� Update-Database � ���������� �������. � ����� ���� ������ Seed() ��� ������ ������� �� ���������:

 	   context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            
	 //context.Shops.AddOrUpdate(s => s.Name, shops);
            
	   context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);

��� ������ ������� ��:

         //context.ShopTypes.AddOrUpdate(s => s.Id, shopTypes);
            
	   context.Shops.AddOrUpdate(s => s.Name, shops);
            
	 //context.ProductTypes.AddOrUpdate(p => p.Id, productTypes);

����� ���� �������� �� ����� ��������� ������������, � ������ ����� �������� ���������.