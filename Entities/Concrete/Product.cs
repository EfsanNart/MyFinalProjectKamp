using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{  //public yazdık çünki bu classa diğer katmanlarda ulaşabilsin demek
    //çünki data acces ürünü ekliyecek ,business ürünü kontrol edecek
    //console ürünü gösterecek yani entitiesi bu 3 katmanda kullanacak 
    //bunun için erişim sağlıyorum
    //NOT=Bir classın default u internal dır yani sadece entities erişebilir

   public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string  ProductName{ get; set; }
        public short UnitsInStock { get; set; } //short int in küçüğü
        public decimal UnitPrice { get; set; }
    }
}
