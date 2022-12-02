using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 9. Найти все трехзначные простые числа (простым называется 
    натуральное число, большее 1, не имеющее других делителей, 
    кроме единицы и самого себя) */

namespace Lab_3_2_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
