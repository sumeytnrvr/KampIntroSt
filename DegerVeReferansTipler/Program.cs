using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    // int decimal float double bool = değer tip
    // array class interface = referans tip
    // değer tipi stack te tutulur (Sadece değeri kopyalar. Bağlantı kopar.)
    // referans tip heap de tutulur (Bellekten adresi tutar. Bağlantı kopmaz.)
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30; 
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

        }
    }
}
