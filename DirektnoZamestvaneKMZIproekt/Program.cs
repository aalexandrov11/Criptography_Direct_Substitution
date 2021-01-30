using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirektnoZamestvaneKMZIproekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Меню:\n" + "0. Изход\n" + "1. Задача\n" + "2. Криптиране на съобщение\n" + "3. Декриптиране на съобщение\n" + "Избор: ");
            String izbor = Console.ReadLine();
            switch (izbor)
            {
                case "0":
                    Environment.Exit(1);
                    break;
                case "1":
                    zadacha();
                    break;
                case "2":
                    Console.WriteLine("Въведете явно съобщение:\n");
                    String fullText = Console.ReadLine();
                    String kriptograma = Kriptirane.Cryptin(fullText);
                    Console.WriteLine("Криптограма:\n" + kriptograma);
                    break;
                case "3":
                    Console.WriteLine("Въвдете криптограмата:\n");
                    String message = Console.ReadLine();
                    String qven = Kriptirane.Decryptin(message);
                    Console.WriteLine("Явен текст:\n" + qven);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            void zadacha()
            {
                string zad = "ОТ СМЕТКА С № 320 201 642 881 7 НА БАНКА \"БИОХИМ\" ДА СЕ ПРЕХВЪРЛЯТ USD 10 000 000 В КОРЕСПОНДЕНТСКА БАНКА NY 20361-8975.";
                String test = Kriptirane.Crypt(zad);
                Console.WriteLine("Криптограма -> " + test);
                Console.WriteLine("\nИскате ли да се криптира без интервал?(Y/N): ");
                char l = Convert.ToChar(Console.ReadLine());
                if (l == 'Y' || l == 'y')//Console.Read() == 'y')
                {
                    //String test1 = Kriptirane.CryptWithoutSpace(zad);
                    Console.WriteLine("Криптограма без интервал -> " + Kriptirane.CryptWithoutSpace(zad));
                }
                Console.WriteLine("\nИскате ли да декриптирате съобщението?(Y/N): ");
                string s = Console.ReadLine();
                char o = Convert.ToChar(s);
                if (o == 'Y' || o == 'y')
                {
                    Console.WriteLine("Явен текст -> " + Kriptirane.Decrypt(test));
                }
            }
            //string zad = "ОТ СМЕТКА С № 320 201 642 881 7 НА БАНКА \"БИОХИМ\" ДА СЕ ПРЕХВЪРЛЯТ USD 10 000 000 В КОРЕСПОНДЕНТСКА БАНКА NY 20361-8975.";
            //String test = Kriptirane.Crypt(zad);
            //Console.WriteLine("Криптограма -> " + test);
            //Console.WriteLine("\nИскате ли да се криптира без интервал?(Y/N): ");
            //char l = Convert.ToChar(Console.ReadLine());
            //if (l == 'Y' || l == 'y')//Console.Read() == 'y')
            //{
            //    //String test1 = Kriptirane.CryptWithoutSpace(zad);
            //    Console.WriteLine("Криптограма без интервал -> " + Kriptirane.CryptWithoutSpace(zad));
            //}
            //Console.WriteLine("\nИскате ли да декриптирате съобщението?(Y/N): ");
            //string s = Console.ReadLine();
            //char o = Convert.ToChar(s);
            //if (o == 'Y' || o == 'y')
            //{
            //    Console.WriteLine("Явен текст -> " + Kriptirane.Decrypt(test));
            //}
            Console.ReadKey();
        }
    }
}
