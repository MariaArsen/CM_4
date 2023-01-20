using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int negative, positive;
            Console.WriteLine("Введите числа");
            int number;
            negative = 0; 
            positive = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)  negative++;
                else if (number > 0)  positive++;  
            }
            while (number != 0);
            if (positive > negative)
            {
                Console.WriteLine("Количестов положительных цифр больше");
            }
            else if (positive < negative)
            {
                Console.WriteLine("Количество отрицательных цифр больше");
            }
            else if (positive == negative)
            {
                Console.WriteLine("Введено одинаковое количество положительных и отрицательных чисел");
            }
            Console.ReadKey();
        }
    }
}
