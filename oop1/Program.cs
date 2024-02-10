using oop1;

Product product1 = new Product(); 
product1.Id = 1;
product1.ProductName = " wilson basketbol topu";
product1.CategoryId = 2;
product1.UnitPrice = 1000;
product1.UnitInStock = 10;

Product product2 = new Product {Id=2,CategoryId=3,ProductName="adidas futbol topu",
    UnitPrice=1250,UnitInStock=12 };

ProductManager productManager= new ProductManager();
productManager.add(product1);
productManager.update(product2);    