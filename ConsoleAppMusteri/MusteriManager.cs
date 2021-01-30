using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppMusteri
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " +

musteri.musteriId + " " + musteri.musteriAdi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " +

musteri.musteriId + " " + musteri.musteriAdi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("müşterileri listelendi : " +

musteri.musteriId + " " + musteri.musteriAdi);
        }
    }
}
