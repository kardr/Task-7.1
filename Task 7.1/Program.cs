using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку символов: ");
            string s = Convert.ToString(Console.ReadLine());
            var set = new HashSet<char>();
            foreach (var chr in s)
            {
                set.Add(chr);
            }
            Console.WriteLine("Различных символов в строке: " + set.Count);
            Console.ReadLine();
        }
    }
}
