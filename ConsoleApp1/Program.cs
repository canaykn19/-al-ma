using Metotlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi= "elma";
            double Fiyati = 15;
            string Aciklama = "amasya elması ";
            string[] Meyveler = new string[] { };

            urun urun1 = new urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            
            urun urun2 = new urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";
            urun[] urunler = new urun[] { urun1, urun2 };
          //type-safe (tip güvenliği)
            foreach (urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("-----------Metotlar-------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager=new SepetManager();
            sepetManager.Ekle(urun1); 
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil",12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 12,8);

            Console.ReadKey();

        }
    }
}
// tekrar tekrar kod kullanımını sağlayan kod blokları(dont repeat yourself-DRY)
