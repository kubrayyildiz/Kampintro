using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Adı                :  " +  musteri.Adi);
            Console.WriteLine("Müşteri SoyAdı             :  " + musteri.Soyadi);
            Console.WriteLine("Müşteri Yaşı               :  " + musteri.Yas);
            Console.WriteLine("Müşteri Doğum Yeri         :  " + musteri.DogumYeri);
            Console.WriteLine("Müşteri Doğum Tarihi       :  " + musteri.DogumTarihi);
            Console.WriteLine("Müşteri Anne Kızlık Soyadı :  " + musteri.AnneKizlikSoyadi);
        }

    }
}
