using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Diziler
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            #region Deneme
            //int[] sayilar = new int[4];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[3] = 40;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);


            //}
            //Console.ReadLine();



            // string[] isimler = { "nesibe", "arzum", "betül" };
            // double[] ondalikli_sayilar = { 1.44, 2.35, 4.56 };
            //char[] karakter = { 'a', '1', 'b' };
            //for(int i =0; i< karakter.Length; i++)
            //{
            //    Console.WriteLine(karakter[i]);
            //}


            //Console.ReadLine();


            //int[] sayilar = new int[4];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write("Sayılar dizisinin "+(i+0)+". değerini giriniz:");
            //    sayilar[i] =int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("*******************************");

            //for (int i = 0;i < sayilar.Length;i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //Console.ReadLine();


            //// bir diaide adet sayısını bulmak

            //int[] sayilar = { 10, 20, 30, 10, 20, 65, 100, 95, 95, 68, 35};
            //int adet = 0;
            //int sayi;

            //Console.Write("Bir sayı giriniz: ");
            //sayi= Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayi == sayilar[i])
            //    {
            //        adet++;
            //    }
            //}

            //if (adet == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı bulunamadı...");
            //}
            //else 
            //{
            //    Console.WriteLine("Girdiğiniz sayı dizide bulundu...");
            //    Console.WriteLine("Adet:"+adet);
            //}


            //int[] sayilar = new int[10];
            //int ciftSayilarinToplami=0;
            //int ciftSayilarAdeti=0;

            //int tekSayilarinToplami=0;
            //int tekSayilarinAdeti=0;

            //int kullaniciDeger;

            //for (int i = 0; i < sayilar.Length; i++) 
            //{
            //    Console.Write((i+1)+". değeri giriniz :");
            //    kullaniciDeger = int.Parse(Console.ReadLine());
            //    sayilar[i] = kullaniciDeger;
            //}

            //for (int j = 0; j < sayilar.Length; j++)
            //{
            //    if (sayilar[j] % 2 == 0)
            //    {
            //        ciftSayilarAdeti++;
            //        ciftSayilarinToplami += sayilar[j];
            //    }
            //    else 
            //    {
            //        tekSayilarinAdeti++;
            //        tekSayilarinToplami += sayilar[j];
            //    }
            //}
            //if (ciftSayilarinToplami > tekSayilarinToplami)
            //{
            //    Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür.");
            //}
            //else 
            //{
            //    Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür.");
            //}

            //Console.WriteLine("******************************************************************");

            //Console.WriteLine("Çift sayıların toplamı :"+ ciftSayilarinToplami);
            //Console.WriteLine("Çift sayıların adedi :"+ ciftSayilarAdeti);
            //Console.WriteLine("******************************************************************");
            //Console.WriteLine("Tek sayıların toplamı"+ tekSayilarinToplami);
            //Console.WriteLine("Tek sayıların adedi :"+ tekSayilarinAdeti);

            //Console.ReadLine();
            //int[,] matris = new int[3, 3];

            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        matris[i, j] = i + j;
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.Write("Kaç öğrenci kaydetmek istiyorsunuz: ");
            int ogrenciSayisi= int.Parse(Console.ReadLine());


                // Öğrenci bilgilerini tutacak diziler oluştur
            double[] numaralar = new double[ogrenciSayisi];
            string[] isimler = new string[ogrenciSayisi];
            string[] soyİsimler= new string[ogrenciSayisi];
            float[] vizeNotlari = new float[ogrenciSayisi];
            float[]finalNotlari= new float[ogrenciSayisi];
            float[] ortalamalar=new float[ogrenciSayisi];
            string[] harfNotlari=new string[ogrenciSayisi];

            // Öğrenci bilgilerini al
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write((i + 1) + ". Öğrencinin numarası: ");
                numaralar[i] = double.Parse(Console.ReadLine());

                Console.Write((i + 1) + ". Öğrencinin ismi: ");
                isimler[i] = Console.ReadLine();

                Console.Write((i + 1) + ". Öğrencinin soyismi: ");
                soyİsimler[i] = Console.ReadLine();

                Console.Write((i + 1) + ". Öğrencinin vize notu: ");
                vizeNotlari[i] = float.Parse(Console.ReadLine());

                Console.Write((i + 1) + ". Öğrencinin final notu: ");
                finalNotlari[i] = float.Parse(Console.ReadLine());


                ortalamalar[i] = (vizeNotlari[i] * 0.4f) + (finalNotlari[i] * 0.6f);
                if (ortalamalar[i] >= 90)
                    harfNotlari[i] = "AA";
                else if (ortalamalar[i] >= 80)
                    harfNotlari[i] = "BA";
                else if (ortalamalar[i] >= 70)
                    harfNotlari[i] = "BB";
                else if (ortalamalar[i] >= 60)
                    harfNotlari[i] = "CB";
                else if (ortalamalar[i] >= 50)
                    harfNotlari[i] = "CC";
                else if (ortalamalar[i] >= 40)
                    harfNotlari[i] = "DC";
                else if (ortalamalar[i] >= 30)
                    harfNotlari[i] = "DD";
                else
                    harfNotlari[i] = "FF";
            }

            Console.WriteLine("\nÖğrenci Bilgileri");
            Console.WriteLine("{0,-15}{1,-20} {2,-20} {3,-20} {4,-15} {5, -15} {6,-10}","Numara","İsim", "Soyisim","Vize Notları", "Final Notları", "Ortalama", "Harf Notu" );
            Console.WriteLine(new string('-', 120));

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine("{0,-15} {1,-20} {2,-20} {3,-20} {4,-15} {5, -15:N} {6,-10}", numaralar[i], isimler[i], soyİsimler[i], vizeNotlari[i], finalNotlari[i], ortalamalar[i], harfNotlari[i]);
            }















        }

    }
}
    














    













    