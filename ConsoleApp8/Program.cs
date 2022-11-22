Product product = new(1,"a",6);
Product product2 = new(1,"b",6);

ProductDb ProductDb = new();

ProductDb.AddProduct(product);
ProductDb.AddProduct(product2);


ProductDb.SearchProduct2("bnhghg");


