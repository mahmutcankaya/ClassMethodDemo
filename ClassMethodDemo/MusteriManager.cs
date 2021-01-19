using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();
        
        public void MusteriEkle() 
        {
            musteri.Id = 123;
            musteri.Adi = "Mahmut Can Kaya";
            musteri.Soyadi = " KAYA";
            musteri.VatandaslikNo = 12222222222;
            musteri.Adresi = "SAHINBEY/GAZIANTEP";

            Console.WriteLine("Musteri Eklendi");

        } 

        public void MusteriListele()
        {
            Console.WriteLine("Musteri Listelendi");
            Musteri[] musteriler = new Musteri[] { musteri };

            foreach (var musteri in musteriler)
            {

                Console.WriteLine("Musteri Id: " + musteri.Id + "\n Musteri Adi: " + musteri.Adi + "\n Musteri Soyadi: " + musteri.Soyadi + "\n Musteri Vatandaslik Numarasi: " + musteri.VatandaslikNo + "\n Musteri Adresi: " + musteri.Adresi + "\n");
     
            }

        }


        public void MusteriSil()
        {
            if (musteri.Id ==1)
            {
                Console.WriteLine("Musteri Silindi");
            }
        }
    }
}
