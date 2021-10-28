using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Ввести с клавиатуры предложение. 
 * Предложение представляет собой слова, разделенные пробелом. 
 * Знаки препинания не используются. Найти самое длинное слово в строке.*/
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания:");
            string str = Console.ReadLine();
            string[] strArr = str.Split();
            int maxLen = 0;
            string strLong = "";
            foreach (string s in strArr)
            {
                if (maxLen<s.Length)
                {
                    strLong = s;
                    maxLen = s.Length;
                }
            }
            Console.WriteLine($"Самое длинное слово - \"{strLong}\".");
            Console.ReadKey();
        }
    }
}
