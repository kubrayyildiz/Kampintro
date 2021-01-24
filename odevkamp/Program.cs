using System;
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // ürünleri tanıtalım
        Urun urun1 = new Urun();
        urun1.urunAdi = "Samsung Galaxy Tab A 8 SM-T290 32GB Tablet Gümüş SM-T290NZ";
        urun1.urunFiyat = 1110;
        urun1.urunIndirim = 3;
        urun1.urunYorumSayisi = 1571;
        urun1.urunDegerlendirme = 7;

        Urun urun2 = new Urun();
        urun2.urunAdi = "Viomi V2 Pro Akıllı Robot Süpürge V-RVCLM21B";
        urun2.urunFiyat = 2960;
        urun2.urunIndirim = 18;
        urun2.urunYorumSayisi = 764;
        urun2.urunDegerlendirme = 8;


        Urun urun3 = new Urun();
        urun3.urunAdi = "logitech G29 Direksiyon + G29 Shifter / G29 Vites 885370902297al31";
        urun3.urunFiyat = 3500;
        urun3.urunIndirim = 2;
        urun3.urunYorumSayisi = 102;
        urun3.urunDegerlendirme = 6;


        Urun urun4 = new Urun();
        urun4.urunAdi = "Xiaomi Mi Band 3 Akıllı Bileklik Saat Global Türkçe Versiyon GB900XIA002";
        urun4.urunFiyat = 106;
        urun4.urunIndirim = 8;
        urun4.urunYorumSayisi = 5634;
        urun4.urunDegerlendirme = 10;
        //ürünlerin içerisinde gezmek için dizinin içine atayalım
        Urun[] urunler = new Urun[] { urun1, urun2, urun3,urun4 };
        Console.WriteLine("--------------------Foreach Döngüsü ile -------------------");

        foreach (var urun in urunler)
        {
            Console.WriteLine("Ürün Adı :  "
            + urun.urunAdi + " / " + urun.urunFiyat + "₺" + " / " + "%"+urun.urunIndirim + " / " + urun.urunYorumSayisi + "yorum" + " / " + urun.urunDegerlendirme);
        }
        Console.WriteLine("--------For Döngüsü ile--------");
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine(urunler[i].urunAdi + "   " + urunler[i].urunFiyat + "₺" + "   " + "%" + urunler[i].urunIndirim + "   " + "Yorum sayısı :" + urunler[i].urunYorumSayisi + "Ürün değerlendirmesi:" + urunler[i].urunDegerlendirme);
        }
        Console.WriteLine("--------While Döngüsü ile------");
        int a = 0;
        int b = urunler.Length;
        while (a < b) ;
        {
            Console.WriteLine(urunler[a].urunAdi + " " + urunler[a].urunFiyat+"₺" + "   " + "%" + urunler[a].urunIndirim + "  " + "Ürün değerlendirmesi: " + urunler[a].urunDegerlendirme + "  " + "Yorum sayısı :" + urunler[a].urunYorumSayisi);
            a++;

        }
    }
}
class Urun
{
    public string urunAdi { get; set; }
    public int urunFiyat { get; set; }
    public int urunDegerlendirme { get; set; }
    public int urunIndirim { get; set; }
    public int urunYorumSayisi { get; set; }
}
