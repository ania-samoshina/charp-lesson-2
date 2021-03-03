using System;

namespace Task1
{
    //Написать метод, возвращающий минимальное из трёх чисел
    public class Min
    {
        public static void Min1()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int min;

            if (a < b && a < c) min = a;
            else if (b < a && b < c) min = b;
            else min = c;

            Console.WriteLine($"min = {min}");


        }
    }
}
