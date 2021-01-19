using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle();
            musteriManager.MusteriListele();
            musteriManager.MusteriSil();
        }
    }
}
