using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string choicedBook = "";
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
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                
                string nums = Console.ReadLine();
                Console.WriteLine();
                switch (nums)
                {
                    case "1":Console.WriteLine("Çalıkuşu: 12 TL"); break;
                    case "2": Console.WriteLine("Yaban: 8 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal: 14 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyunlar: 16 TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden: 19 TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf: 10 TL"); break;
                    case "7": Console.WriteLine("Tuna Kılavuzu: 15 TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası: 21TL"); break;
                    case "9": Console.WriteLine("Altıncı Koğuş: 27 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 5 TL"); break;
                    case "11": Console.WriteLine("Bir Kuzey Macerası: 26 TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi: 17 TL"); break;
                    default: Console.WriteLine("Böyle bir kitap mevcut değil, numarayı kontrol edin");break;

                }
            }
            if (option.Equals('2'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Okur Kaydı  *****");
                Console.WriteLine();

                string name, surname, university;
                Console.Write("Adınız: ");
                name = Console.ReadLine();
                Console.Write("Soyadınız: ");
                surname = Console.ReadLine();
                Console.Write("Universite: ");
                university = Console.ReadLine();
                string dbPath = "C:\\Users\\malid\\OneDrive\\Masaüstü\\Users.txt";
                StreamWriter sw = new StreamWriter(dbPath);
                
                sw.WriteLine(name+"/"+surname+"/"+university);
                sw.Close();
            }
            if (option.Equals('3'))
            {
                Console.WriteLine();
                Console.WriteLine("***********************************************");
                Console.WriteLine("*******                                 *******");
                Console.WriteLine("**********  Günün Kitabı : Çalıkuşu  **********");
                Console.WriteLine("*******                                 *******");
                Console.WriteLine("***********************************************");


            }
            if (option.Equals('4'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Kitap Arşivi  *****");
                Console.WriteLine();
                Console.WriteLine("***********************************************");
                Console.WriteLine("*******                                 *******");
                FileStream fs = new FileStream("C:\\Users\\malid\\OneDrive\\Masaüstü\\Books.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
                sr.Close();
                fs.Close();
                Console.WriteLine("*******                                 *******");
                Console.WriteLine("***********************************************");
            }
            if (option.Equals('5'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Kitap Al  *****");
                Console.WriteLine("Tek sefer de en fazla 10 kitap alabilirsiniz.");
                for(int i = 1; i < 10; i++)
                {
                    Console.WriteLine();
                    Console.Write("Almak istediğiniz kitabın numarasınız giriniz: ");
                    choicedBook = Console.ReadLine();
                    if(choicedBook == "1")
                    {
                        sum += 12;
                    }else if(choicedBook == "2")
                    {
                        sum += 8;
                    }else if (choicedBook == "3")
                    {
                        sum += 14;
                    }else if (choicedBook == "4")
                    {
                        sum += 16;
                    }
                    else if (choicedBook == "5")
                    {
                        sum += 19;
                    }
                    else if (choicedBook == "6")
                    {
                        sum += 10;
                    }
                    else if (choicedBook == "7")
                    {
                        sum += 15;
                    }
                    else if (choicedBook == "8")
                    {
                        sum += 21;
                    }
                    else if (choicedBook == "9")
                    {
                        sum += 27;
                    }
                    else if (choicedBook == "10")
                    {
                        sum += 5;
                    }
                    else if (choicedBook == "11")
                    {
                        sum += 26;
                    }
                    else if (choicedBook == "12")
                    {
                        sum += 17;
                    }
                    else
                        Console.WriteLine("Geçersiz bir kitap numarası girdiniz.");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap almak ister misiniz? ");
                        string answ = Console.ReadLine();
                        if (answ == "h" || answ == "hayır" || answ == "H" || answ == "HAYIR")
                        {
                            break;
                        }
                }
                Console.WriteLine("Toplam ücret:" + sum);
            }
            if (option.Equals('6'))
            {
                Console.WriteLine();
                Console.WriteLine("***** Tahmin Oyunu  *****");
                int guest = 0;
                Random rnd = new Random();
                int numRnd = rnd.Next(1, 100);
                while (numRnd != guest)
                {
                    Console.Write("Enter a number: ");
                    guest = Convert.ToInt16(Console.ReadLine());
                    if (guest > numRnd) { Console.WriteLine("Enter number less than your number"); }
                    else if (guest < numRnd) { Console.WriteLine("Enter number greater than your number"); }
                    else { Console.WriteLine("You are right! Congratulations!"); }
                }
            }



            Console.ReadKey();
        }
    }
}
