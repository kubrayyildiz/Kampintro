using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kursu";
            string kurs3 = "Java";
            string kurs4 = "python";
            //array- dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kursu" , 
                "Java","python","c++","c#"};


            for ( int i = 0; i <kurslar.Length; i++)  // length - eleman sayısı 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) // dizi elamanı tek tek dolaşmaya yarar.her bir elemanı dolaşırke verdiğimiz takma isim = kurs 
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
