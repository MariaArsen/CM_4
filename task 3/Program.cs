using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            int n = 0;
            while (j==n)
            {
                n += a - c;
                j += b - c;
            }
            Console.WriteLine("Количество квадратов, размещенных на прямоугольнике {0}", n);
            Console.ReadKey();

        }
    }
}
