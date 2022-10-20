using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//METOTLAR(FONKSİYONLAR)

//metotlar tekrar tekrar kullanılabilmeyi sağlayan kod bloklarıdır.


namespace Metotlar
{
    class SepetManager
    {
        //parametreli olarak metodu yaz(ürün adına göre ürünü sepete ekleme)
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(" sepete eklendi: "+urun.UrunAdi);
        }
       
    }
}
