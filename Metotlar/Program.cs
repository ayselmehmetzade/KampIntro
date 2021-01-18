using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 10;

            Urun urun2 = new Urun();

            urun2.Adi = "Çilek";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Çilek gibi çilek";
            urun2.stokAdedi = 55;

            Urun urun3 = new Urun();

            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Aciklama = "Diyarbakır Karpuzu";
            urun3.stokAdedi = 2;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------Metotlar-------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil", 12,2);
            sepetManager.Ekle2("Elma", "Deneme", 50,4);
            sepetManager.Ekle2("Karpuz", "Sarı", 12,10);
        }
    }
}
