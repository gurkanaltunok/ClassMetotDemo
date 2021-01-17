using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine(musteri.Id + " ID Numaralı Müşteri Eklendi : "+musteri.Ad + " "+ musteri.Soyad);
        }

        public void MusterSil(Musteri musteri)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine(musteri.Id + " ID Numaralı Müşteri Silindi : " + musteri.Ad + " " + musteri.Soyad);
            
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("*===============================================*");
            Console.WriteLine("Müşteri ID : " + musteri.Id);
            Console.WriteLine("Müşteri Adı : " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("Hesap Tipi : " + musteri.HesapTipi);
        }
    }
}
