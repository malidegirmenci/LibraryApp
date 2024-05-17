using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi             **  Yabancı Kitaplar Kategorisi         **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri                 **  7-Tuna Kılavuzu: Jules Verne        **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri                   **  8-Bir Kuzey Macerası: Jack London   **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip          **  9-Altıncı Koğuş: Anton Çehov        **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: Oğuz Atay         **  10-Kumarbaz: Dostoyevski            **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden: Hasan Ali Yücel  **  11-Bir Kuzey Macerası: Jack London  **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: Sabahattin Ali      **  12-Vişne Bahçesi: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü  *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarasınız yazınız: ");
            char option = Convert.ToChar(Console.ReadLine());
            if (option.Equals('1'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Fiyat Sorgulama  *****");
            }
            if (option.Equals('2'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Okur Kaydı  *****");
            }
            if (option.Equals('3'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Günün Kitabı  *****");
            }
            if (option.Equals('4'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Kitap Arşivi  *****");
            }
            if (option.Equals('5'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Kitap Al  *****");
            }
            if (option.Equals('6'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Oyun  *****");
            }



            Console.ReadKey();
        }
    }
}
