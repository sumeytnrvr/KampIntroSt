using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kmapı";
            string kurs2 = "Programlamaya Giriş Kampı";
            string kurs3 = "Java";

            //array - dizi
            //bir çok değişken tutmak yerine kullanılır

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Giriş Kampı",
                "Java",
                "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            // Dizi temelli yapıları tek tek dönmeye yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);                  
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
