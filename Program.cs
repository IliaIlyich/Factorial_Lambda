using System;

namespace Factorial_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение факториала");
            int n = int.Parse(Console.ReadLine()); 
            Func<int, int> func=null;
            Console.WriteLine("Факториал числа {0}! = {1}", n, (func = n => 
            {
                if (n==1) return 1;
                return n * func(n-1);   
            })(n)); 
        }
    }
}
