using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //Çıplak class Kalmasın bu nedemek eğerki bir class aşağıdaki Category
    //gibi herhangi bir inheritance ve interface implementasyonu almıyor ise ilerde sıkıntı yasarız
    //bu yüzden bu varlıkları gruplama yontemine gideriz nedir bu gruplama?
    //şudur concrete klasorindeki sınıflar bir veri tabanı tablosuna karşılık geliyor
    
    //Yani biz IEntity Category görüyorsak bu mimaride anlyıyoruzki bu bir veri tabanı tablosudur
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
