using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfNotuHesaplatmaOdevi.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Notunuzu Bu Alanda hesaplayın");
                string[,] ogrenciler = new string[4, 2];
                Console.Write("Ad : ");
                string ad = Console.ReadLine();
                Console.Write("Soyad : ");
                string soyad = Console.ReadLine();
                Console.WriteLine("Merhaba {0} {1}", ad, soyad);
                double vize, final, final2, ort;
                Console.Write("Vize Notunuzu Giriniz: ");
                double.TryParse(Console.ReadLine(), out vize);
                Console.Write("Final Notunuzu Giriniz: ");
                double.TryParse(Console.ReadLine(), out final);
                if (vize < 0)
                {
                    vize = 0;
                }
                if (final < 0)
                {
                    final = 0;
                }
                if (vize > 100)
                {
                    vize = 100;
                }
                if (final > 100)
                {
                    final = 100;
                }
                vize = vize * 4 / 10;
                final2 = final * 6 / 10;
                ort = vize + final2;
                if (final < 50)
                {
                    Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: FF");
                    Console.Write(" Final Sınavından 50 Barajını Geçemediğiniz İçin Kaldınız!!!");
                }
                else
                {
                    if (ort >= 90 && ort <= 100)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: AA");
                    }
                    else if (ort >= 80 && ort < 90)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: BA");
                    }
                    else if (ort >= 70 && ort < 80)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: BB");
                    }
                    else if (ort >= 60 && ort < 70)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: CB");
                    }
                    else if (ort >= 50 && ort < 60)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: CC");
                    }
                    else if (ort >= 45 && ort < 50)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: DD");
                    }
                    else if (ort >= 0 && ort < 45)
                    {
                        Console.Write(" Ortalamanız: " + ort + " Harf Notunuz: FF");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

