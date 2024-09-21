using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static double VKIHesapla(double kilo, double boyCm)
        {
            double boyMetre = boyCm / 100;
            return kilo / (boyMetre * boyMetre);
        }

        static string VKISiniflandir(double vki)
        {
            if (vki < 18.5)
                return "Zayıf";
            else if (vki >= 18.5 && vki <= 24.9)
                return "Normal";
            else if (vki >= 25.0 && vki <= 29.9)
                return "Fazla Kilolu";
            else if (vki >= 30.0 && vki <= 34.9)
                return "Şişman (Obez) - I. Sınıf";
            else if (vki >= 35.0 && vki <= 44.9)
                return "Şişman (Obez) - II. Sınıf";
            else // vki >= 45.0
                return "Aşırı Şişman (Aşırı Obez) - III. Sınıf";
        }
        static double ErkekIdealKiloHesapla(double boy)
        {
            // Erkek için Broca formülü: (boy - 100) * 0.9
            return (boy - 100) * 0.9;
        }

        static double KadinIdealKiloHesapla(double boy)
        {
            // Kadın için Broca formülü: (boy - 100) * 0.85
            return (boy - 100) * 0.85;
        }

        static void Main(string[] args)
        {
            Console.Write("Cinsiyetinizi girin (E/K): ");
            string cinsiyet = Console.ReadLine().ToUpper();

            Console.Write("Boyunuzu cm cinsinden girin: ");
            double boyCm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kilonuzu kg cinsinden girin: ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            double vki = VKIHesapla(kilo, boyCm);

            Console.WriteLine($"\nVücut Kitle İndeksiniz (VKI): {vki}");

            string durum = VKISiniflandir(vki);

            Console.WriteLine($"Durumunuz: {durum}");

            if (cinsiyet == "E")
            {
                double idealKilo = ErkekIdealKiloHesapla(boyCm);
                Console.WriteLine($"İdeal Kilonuz: {idealKilo}");
            }
            else
            {
                double idealKilo = KadinIdealKiloHesapla(boyCm);
                Console.WriteLine($"İdeal Kilonuz: {idealKilo}");
            }

            Console.ReadLine();

        }
    }
}
