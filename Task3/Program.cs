using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дана строка S. Из строки требуется удалить текст, 
 * заключенный в фигурные скобки. В строке может быть несколько фрагментов, 
 * заключённых в фигурные скобки. Возможно использование вложенных фигурных скобок, 
 * необходимо, чтобы программа это учитывала.*/
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение c фрагментами в фигурных скобках:");
            string str = Console.ReadLine();
            while (str.IndexOf("{") != -1)
            {
                int startPos = str.IndexOf("{");
                int insidePos = str.IndexOf("{", startPos+1);
                int endPos = str.IndexOf("}");
                if(insidePos < endPos && insidePos != -1)
                {
                    while (insidePos < endPos && insidePos != -1)
                    {
                        insidePos = str.IndexOf("{", insidePos+1);
                        endPos = str.IndexOf("}", endPos+1);
                    }
                }
                str = str.Remove(startPos, endPos - startPos + 1);
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
