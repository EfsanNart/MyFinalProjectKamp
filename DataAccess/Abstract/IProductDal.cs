using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{  //IProductDal isimlendirmemiz: I onun interface oldugunu anlatır,
    //aradaki ilk isim hangi tabloya karşılık geldiğini anlatır entity, yani
    //Dal ise onun hangi katmana denk geldğini anlatır
    //Dao da dal yerine kullanılabilir
    public interface IProductDal //public yazmayı unutma!
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
