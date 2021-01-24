using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        // naming convention
        //syntax yazım şekilleri
        public void Ekle(Urun urun) // normal parantez olursa metod vardır.
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi:  "+ urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama ,double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi:  " + urunAdi);

        }
    }
}
