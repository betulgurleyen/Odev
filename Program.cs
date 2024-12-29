﻿namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kaç öğrenci kaydetmek istiyorsunuz? ");
                int ogrencisayi = int.Parse(Console.ReadLine());

                string[,] ogrencibilgileri = new string[ogrencisayi, 7];
                double toplamnot = 0;
                double endusuk = 101;
                double enyuksek = -1;

                for (int i = 0; i < ogrencisayi; i++)
                {

                    Console.Write($"{i + 1}.Öğrencinin numarasını giriniz: ");
                    ulong numara = ulong.Parse(Console.ReadLine());
                    ogrencibilgileri[i, 0] = numara.ToString();



                    Console.Write($"{i + 1}.Öğrencinin ismini giriniz: ");
                    string ad = Console.ReadLine();
                    ogrencibilgileri[i, 1] = ad;


                    Console.Write($"{i + 1}.Öğrencinin soyismini giriniz: ");
                    string soyad = Console.ReadLine();
                    ogrencibilgileri[i, 2] = soyad;

                    double vize, final, ortalama;
                    while (true)
                    {
                        Console.Write($"{i + 1}.Öğrencinin vize notunu giriniz: ");
                        vize = double.Parse(Console.ReadLine());
                        if (vize >= 0 && vize <= 100)
                            break;

                        else
                            Console.WriteLine("Hatalı giriş yaptınız. 0-100 aralığında bir not girişi yapınız.");

                    }
                    ogrencibilgileri[i, 3] = vize.ToString();

                    while (true)
                    {
                        Console.Write($"{i + 1}.Öğrencinin final notunu giriniz: ");
                        final = double.Parse(Console.ReadLine());
                        if (final >= 0 && final <= 100)
                            break;

                        else
                            Console.WriteLine("Hatalı giriş yaptınız. 0-100 aralığında bir not girişi yapınız.");
                    }
                    ogrencibilgileri[i, 4] = final.ToString();

                    ortalama = vize * 0.4f + final * 0.6f;
                    ogrencibilgileri[i, 5] = ortalama.ToString();
                    toplamnot += ortalama;

                    if (ortalama > enyuksek)
                        enyuksek = ortalama;
                    if (ortalama < endusuk)
                        endusuk = ortalama;

                    string harfnotu;
                    if (ortalama >= 85)
                        harfnotu = "AA";
                    else if (ortalama >= 75)
                        harfnotu = "BA";
                    else if (ortalama >= 60)
                        harfnotu = "BB";
                    else if (ortalama >= 50)
                        harfnotu = "CB";
                    else if (ortalama >= 40)
                        harfnotu = "CC";
                    else if (ortalama >= 30)
                        harfnotu = "DC";
                    else if (ortalama >= 20)
                        harfnotu = "DD";
                    else if (ortalama >= 10)
                        harfnotu = "FD";
                    else
                        harfnotu = "FF";

                    ogrencibilgileri[i, 6] = harfnotu;
                    Console.WriteLine();
                }

                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-20} {6,-5}", "Numara", "İsim", "Soyisim", "Vize Notu", "Final Notu", "Ortalama", "Harf Notu");

                Console.WriteLine("-------------------------------------------------------------------------------------------");

                for (int i = 0; i < ogrencisayi; i++)
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-20} {6,-5}", ogrencibilgileri[i, 0], ogrencibilgileri[i, 1], ogrencibilgileri[i, 2], ogrencibilgileri[i, 3], ogrencibilgileri[i, 4], ogrencibilgileri[i, 5], ogrencibilgileri[i, 6]);
                }

                double sınıfort = toplamnot / ogrencisayi;

                Console.WriteLine($"\nSınıf Ortalaması:{sınıfort}\nEn yüksek not : {enyuksek}\nEn düşük not : {endusuk}");
            }

            catch (FormatException)
            {
                Console.WriteLine("Girişi rakamlarla yapınız..");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Aşma hatası...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu...");

                Console.WriteLine($"Tarih:{DateTime.Now}\nMesaj:{ex.Message}\nBulunduğu yer:{ex.StackTrace}");
            }
            Console.ReadLine();
        }
    }
}
