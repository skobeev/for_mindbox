/*
Задано целое число K (>0) и коллекция целых чисел A. Начиная с элемента A с порядковым номером K, 
извлечь из A все нечетные двузначные числа, отсортировать их по убыванию.

Код:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabN6
{

    class Program
    {
        static void Main(string[] args)
        {  
Random ran = new Random();
            List<int> lst = new List<int>();
            int i = 0;
            while (i < 20)
            {
                lst.Add(ran.Next(1, 100));
                Console.Write(lst[i] + " ");
                i++;
            }
            Console.WriteLine();
            Console.Write("Введите порядковый номер: ");
            int K = int.Parse(Console.ReadLine());
            var r = lst.Where((x, y) => y >= K - 1);
  		Console.WriteLine();
            var e = r.Where(x => (x % 2 != 0) && (x >= 10) && (x < 100)).ToArray();
            foreach (var c in e)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Array.Sort(e);
            Array.Reverse(e);
            foreach (var c in e)
            {
                Console.Write(c + " ");
            }
Console.ReadKey();
        }

       
    }
}
