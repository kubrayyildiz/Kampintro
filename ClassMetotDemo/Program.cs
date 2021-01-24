using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string musteriAdi = "Kübra Nur";
            string musteriSoyadi = "YILDIZ";
            int musteriYasi = 20;
            string musteriAnneKizlikSoyadi = "Doğaner";
            string musteriDogumYeri = "Gaziantep";
            string musteriDogumTarihi = "27/03/2000";

            string[] musteriler = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Zekeriya";
            musteri1.Soyadi = "YILDIZ";
            musteri1.Yas = 58;
            musteri1.DogumYeri = "Gaziantep";
            musteri1.DogumTarihi = "01.01.1962";
            musteri1.AnneKizlikSoyadi = "Gider";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Zeliha";
            musteri2.Soyadi = "YILDIZ";
            musteri2.Yas = 53;
            musteri2.DogumYeri = "Gaziantep";
            musteri2.DogumTarihi = "18/02/1968";
            musteri2.AnneKizlikSoyadi = "Kaplan";


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Aykut";
            musteri3.Soyadi = "YILDIZ";
            musteri3.Yas = 34;
            musteri3.DogumYeri = "Ankara";
            musteri3.DogumTarihi = "17/09/1986";
            musteri3.AnneKizlikSoyadi = "Doğaner";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Tuğba";
            musteri4.Soyadi = "YILDIZ";
            musteri4.Yas = 30;
            musteri4.DogumYeri = "Ankara";
            musteri4.DogumTarihi = "11/05/1989";
            musteri4.AnneKizlikSoyadi = "Doğaner";

            Musteri musteri5 = new Musteri();
            musteri5.Adi = "Kübra Nur";
            musteri5.Soyadi = "YILDIZ";
            musteri5.Yas = 20;
            musteri5.DogumYeri = "Gaziantep";
            musteri5.DogumTarihi = "27/03/2000";
            musteri5.AnneKizlikSoyadi = "Doğaner";


            Musteri[] Musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4,musteri5 };
            {
                foreach (var musteri in Musteriler)
                {
                    Console.WriteLine(musteri.Adi);
                    Console.WriteLine(musteri.Soyadi);
                    Console.WriteLine(musteri.Yas);
                    Console.WriteLine(musteri.DogumYeri);
                    Console.WriteLine(musteri.DogumTarihi);
                    Console.WriteLine(musteri.AnneKizlikSoyadi);
                    Console.WriteLine("----------------------------------");
                }
                Console.WriteLine("----------METODLAR----------");

                MusteriManager musteriManager = new MusteriManager();
                musteriManager.Ekle(musteri1);
                musteriManager.Ekle(musteri2);
                musteriManager.Ekle(musteri3);
                musteriManager.Ekle(musteri4);
                musteriManager.Ekle(musteri5);
                


            }
                


            

            
        }
    }
}
