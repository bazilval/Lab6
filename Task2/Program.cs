using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ввести с клавиатуры предложение. 
 * Предложение представляет собой слова, разделенные пробелом. 
 * Знаки препинания не используются. 
 * Составить программу, определяющую является ли строка палиндромом 
 * без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания:");
            string result = "", strRev = "", str = Console.ReadLine().ToLower().Replace(" ","");

            for (int i = str.Length-1; i >=0; i--)
            {
                strRev += str[i];
            }

            result = (str == strRev) ? "Это палиндром!" : "Это не палиндром.";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
