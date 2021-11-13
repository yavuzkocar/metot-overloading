using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {//out parametreler
            string sayi="999";
            int outsayi;
            bool sonuc=int.TryParse(sayi, out outsayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("basarısız");
            }
            metotlar instance = new metotlar();
            instance.topla(2,3,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);
            
            //metot aşırı yükleme(overloading)
            int ifade = 111;
            instance.ekranayazdır(ifade);
            instance.ekranayazdır(Convert.ToString(ifade));
            instance.ekranayazdır("yavuz"," kocar...");
            //metot imzası
            //metodAdı + parametre sayisi + parametre 

        }
    }

    class metotlar
    {
        public void topla(int a, int b, out int toplam)
        {
            toplam = a + b;
            

        }
        public void ekranayazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdır(int veri)
        {
            Console.WriteLine(veri);
        }
         public void ekranayazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
