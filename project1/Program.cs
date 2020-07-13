using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, m, res1, res2, res3, res4;
            Console.WriteLine("enter the numbers");
            n = Convert.ToInt16(Console.ReadLine());
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter operation you want to do " +
                                 "1--addition  " +
                                 "2--subtraction  " +
                                 "3--multiplication  " +
                                 "4--division");
            i = Convert.ToInt16(Console.ReadLine());
            res1 = n + m;
            res2 = n - m;
            res3 = n * m;
            res4 = n / m;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine($"addition of {n} and {m} is {res1}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"subtraction of {n} and {m} is {res2}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"multiplication of {n} and {m} is {res3}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"division of {n} and {m} is {res4}");
                        break;
                    }
            }



            
        }

    }

}
            

   
