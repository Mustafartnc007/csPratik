//METOTLAR(FONKSİYONLAR)

//metotlar tekrar tekrar kullanılabilmeyi sağlayan kod bloklarıdır.

using Metotlar;

Urun elma =new Urun();
elma.Id = 1;
elma.UrunAdi = "elma";
elma.Fiyati = 15;
elma.Aciklama = "Amasya elması";

Urun karpuz=new Urun();
elma.Id = 2;
karpuz.UrunAdi = "karpuz";
karpuz.Fiyati = 12;
karpuz.Aciklama = "diyarbakır karpuzu";

Urun[] urunler = new Urun[] { elma, karpuz };

foreach (var urun in urunler)
{
    Console.WriteLine("Ürün id: "+urun.Id+" Ürün adı: "+urun.UrunAdi+"  Ürün Fiyatı: "+urun.Fiyati+"  Ürün açıklaması: "+urun.Aciklama);
}


//ENCAPSULATİON
//ekle ornek
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(elma);
sepetManager.Ekle(karpuz);

