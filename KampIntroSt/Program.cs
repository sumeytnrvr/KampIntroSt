using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntroSt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Kategori Etiketi";
            int ogrenciSayisi = 43;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.30;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarBugun>dolarDun)    
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");    
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }       
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);  
            Console.WriteLine(faizOrani);   
        }
    }
}
