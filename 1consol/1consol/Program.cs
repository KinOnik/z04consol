using System;

namespace _1consol
{
    internal class Program
    {
        static double f(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + f(n - 1);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tВведите m:");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\tВведите k:");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.Write($"\n\t Результат: {f(m) + f(2 * k)}");
            }
            catch (Exception)
            {
                Console.Write("\n\n\t****Ошибка ввода, некорректное число****\n\n");
            }
        }
    }
}
