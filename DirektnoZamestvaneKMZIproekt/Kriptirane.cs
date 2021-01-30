using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirektnoZamestvaneKMZIproekt
{
    class Kriptirane
    {
        private static char[] alpha = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'И', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Я', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'N', 'Y', 'U', 'S', 'D', ' ', '"', '¹', '-', 'Ъ' };
        private  static int[] symbl = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 40, 34, 35, 39, 36, 37, 38 };
        
        public static String Crypt(String plain)
        {
            char[] transformText = plain.ToCharArray();//array1.Intersect(array2).Any()//sravqva 2 masiva i tursi dali ima znak ot ediniq koito go nqma v drugiq
            String transformedText = null;
            List<int> textNums = new List<int>();
            int c = 0;
            for (int i = 0; i < transformText.Length; i++)
            {
                if (alpha.Contains(transformText[i]) == false)
                    c++;

                for (int j = 0; j < alpha.Length; j++)
                {
                    if ((transformText[i].Equals(alpha[j])) == true)
                        textNums.Add(symbl[j]);
                    //else
                        //c++;
                }
            }
            Console.WriteLine("Има " + c + " неразрешени символа.\nТе ще бъдат подминавани от криптиращия алгоритъм!\n");
            var a = String.Join(" ", textNums);//textNums.ToArray();
            transformedText = a.ToString();

            return transformedText;
        }

        public static String CryptWithoutSpace(String s)
        {
            char[] alphaS = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'И', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Я', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'N', 'Y', 'U', 'S', 'D', '"', '¹', '-', 'Ъ' };
            int[] symblS = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 40, 34, 39, 36, 37, 38 };
            char[] transformText = s.ToCharArray();
            String transformedText = null;
            List<int> textNums = new List<int>();
            for(int i = 0; i < transformText.Length; i++)
            {
                for(int j = 0; j < alphaS.Length; j++)
                {
                    if (transformText[i].Equals(alphaS[j]))
                        textNums.Add(symblS[j]);
                }
            }
            var a = String.Join(" ", textNums);
            transformedText = a.ToString();

            return transformedText;
        }

        public static String Decrypt(String d)
        {
            String decryptedText = null;
            //List<char> textA = new List<char>();
            StringBuilder textA = new StringBuilder();
            string[] decSymbls = d.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < decSymbls.Length; i++)
            {
                for(int j = 0; j < symbl.Length; j++)
                {
                    if (decSymbls[i].Equals(symbl[j].ToString()))
                        textA.Append(alpha[j]);
                }
            }
            decryptedText = textA.ToString();

            return decryptedText;
        }

        private static char[] alphab = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ю', 'Я', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'O', 'P', 'Q', 'R', 'T', 'V', 'W', 'X', 'Z', 'N', 'Y', 'U', 'S', 'D', ' ', '"', '¹', '-', 'Ъ' };
        private static int[] symbols = new int[] { 1, 2, 3, 4, 5, 6, 41, 42, 7, 43, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 44, 45, 46, 47, 48, 49, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 31, 32, 33, 40, 34, 35, 39, 36, 37, 38 };

        public static String Decryptin(String d)
        {
            String decryptedText = null;
            StringBuilder text = new StringBuilder();
            string[] dSymbls = d.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < dSymbls.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (dSymbls[i].Equals(symbols[j].ToString()))
                        text.Append(alphab[j]);
                }
            }
            decryptedText = text.ToString();
            return decryptedText;
        }

        public static String Cryptin(String d)
        {
            char[] transformText = d.ToCharArray();
            String transformedText = null;
            List<int> textNums = new List<int>();
            int c = 0;
            for (int i = 0; i < transformText.Length; i++)
            {
                if (alphab.Contains(transformText[i]) == false)
                    c++;

                for (int j = 0; j < alphab.Length; j++)
                {
                    if (transformText[i].Equals(alphab[j]))
                        textNums.Add(symbols[j]);
                }
            }
            Console.WriteLine("Има " + c + " неразрешени символа.\nТе ще бъдат подминавани от криптиращия алгоритъм!\n");
            var a = String.Join(" ", textNums);
            transformedText = a;//.ToString();
            return transformedText;
        }
    }
}
