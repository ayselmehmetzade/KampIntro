using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // string kategoriEtiketi="Kategori";
            // int ogrenciSayisi=32000;
            // double faizOrani=1.45;
            // bool sistemeGirisYaptiMi=false;
            // double dolarDun=7.35;
            // double dolarBugun=7.45;

            // if(dolarDun>dolarBugun){
            //   Console.WriteLine("Azalış Butonu");
            // }
            // else if(dolarDun<dolarBugun){
            //   Console.WriteLine("Artış Butonu");
            // }
            // else{
            //   Console.WriteLine("Eşittir Butonu");
            // }

            // if(sistemeGirisYaptiMi==true){
            //   Console.WriteLine("Ayarlar Butonu");
            // }
            // else{
            //   Console.WriteLine("Giriş Butonu");
            // }


            // string kurs1="Yazılım Geliştirme";
            // string kurs2="Programlamaya Giriş";
            // string kurs3="Java Kursu";

            // string[] kurslar= new string[] {"Yazılım Geliştirme","Programlamaya Giriş","Java Kursu","Python Kursu","C++ Kursu","C# Kursu","Angular Kursu"};


            // for(int i=0; i<kurslar.Length; i++){
            //   Console.WriteLine(kurslar[i]);
            // }
            // Console.WriteLine("For bitti");

            // foreach(string kurs in kurslar){
            //   Console.WriteLine(kurs);
            // }

            // Console.WriteLine("Sayfa Sonu");
            string adi = "Aysel";
            int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.KursEgitmeni = "Aysel";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursEgitmeni = "Yusuf";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Python";
            kurs4.KursEgitmeni = "Dilara";
            kurs4.IzlenmeOrani = 100;
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.KursEgitmeni + ": " + kurs.IzlenmeOrani);
            }

            // Console.WriteLine(kurs2.KursAdi + " " + kurs2.KursEgitmeni);
        }
    }

  
}
class Kurs
{
    public string KursAdi { get; set; }
    public string KursEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}