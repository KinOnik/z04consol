using System;

namespace _2consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tВведите натуральное начальное число A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\tВведите натуральное конечное число B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\tРезультат:");
                for (int i = A; i <= B; i++)
                {
                    Console.Write("\n\t");
                    f(i);
                }
            }
            catch(Exception)
            {
                Console.Write("\n\n\t****Введено некорректное число****\n\n");
            }
            
        }

        static void f(int n)
        {
            if (n!=0)
            {
                f(n / 10);
            }
            else return;
            Console.Write(n % 10+" ");
        }
    }
}
