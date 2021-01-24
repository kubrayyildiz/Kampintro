using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        { 
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type safe =tip güvenli java,c#
            foreach (var urun in urunler) //her bir elemanı tek tek gez(ekrana bas)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-----------------------");

            }



            Console.WriteLine("---------Metotlar---------------");
            //instance örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "yeşil elma", 12,9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,8);

        } 
    }
}
