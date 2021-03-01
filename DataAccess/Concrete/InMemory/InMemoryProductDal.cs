using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {  //aşağıdaki kodu bütün metotların dışında classın içinde tanımladık
        //Bu yuzden o class için bu global değişkendir bunları alt çizgiyle veririz
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };
        }
        
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {  //=> lambda denir
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId );
            //p burda takma ad
            //Parantez içinde yazan ifade şunu anlatıyor her p için
            //git bak bakayım p'nin productıd si benim gönderdiğim product'ın
            //Id sine eşitmi eşit ise onun referansını productToDelete e eşitle
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();

        }

        public void Update(Product product)
        { 
            //Gonderdiğim ürün ıd'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
