using System;

namespace Task2
{
    //Написать метод подсчета количества цифр числа.
    public class NOD
    {
        public static void NumberOfDigits()
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Number of digits of the entered number : {0}", i);
            Console.ReadKey();
        }

    }
}
