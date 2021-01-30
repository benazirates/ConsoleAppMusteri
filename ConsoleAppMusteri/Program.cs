using System;

namespace ConsoleAppMusteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 30652364589;
            musteri1.musteriAdi = "Benazir";
            musteri1.musteriSoyadi = "Ateş";
            musteri1.musteriHesapNo = 45698751223156;
            musteri1.musteriAdresi = "X mah. Y sok no: 7 Ataşehir / Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 26584759687;
            musteri2.musteriAdi = "Engin";
            musteri2.musteriSoyadi = "Demiroğ";
            musteri2.musteriHesapNo = 56456987512231;
            musteri2.musteriAdresi = "z mah. p sok no: 11 Beşiktaş / İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 95468231647;
            musteri3.musteriAdi = "Bekir";
            musteri3.musteriSoyadi = "Şeker";
            musteri3.musteriHesapNo = 36456987512231;
            musteri3.musteriAdresi = "a mah. b sok no: 28 ümraniye / İstanbul";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };



            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriId);
                Console.WriteLine(musteri.musteriAdi);
                Console.WriteLine(musteri.musteriSoyadi);
                Console.WriteLine(musteri.musteriAdresi);
                Console.WriteLine("________________________");
            }

            Console.WriteLine("_______________*****____________");

            MusteriManager musteriManeger = new MusteriManager();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Ekle(musteri2);
            musteriManeger.Ekle(musteri3);

            Console.WriteLine("**************");

            musteriManeger.Sil(musteri1);
            musteriManeger.Sil(musteri2);
            musteriManeger.Sil(musteri3);

            Console.WriteLine("**************");
            musteriManeger.Listele(musteri1);
            musteriManeger.Listele(musteri2);
            musteriManeger.Listele(musteri3);
        }
    }
}
