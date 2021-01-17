using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 367241;
            musteri1.Ad = "Gürkan";
            musteri1.Soyad = "Altunok";
            musteri1.HesapTipi = "Vadeli";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 847312;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.HesapTipi = "Vadeli";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 128374;
            musteri3.Ad = "Elon";
            musteri3.Soyad = "Musk";
            musteri3.HesapTipi = "Vadesiz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }

            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriListele(musteri);
            }

            musteriManager.MusterSil(musteri3);

            Console.ReadLine();
        }
    }
}
