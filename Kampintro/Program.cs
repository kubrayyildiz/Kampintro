using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself - Kendini tekrarlama
            // deger tutucu,alias
            string katagoriEtiketi = "Katagori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            dolarDun = 7.35;
            dolarBugun = 7.45;
            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(katagoriEtiketi);
        }
    }
}
