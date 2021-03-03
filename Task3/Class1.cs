using System;

namespace Task3
{
    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    public class OPN
    {
        public static void OddPositiveNumbers()
        {
            int sum = 0;
            int num = 0;
            Console.WriteLine("Enter the numbers: ");

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Sum: " + sum);
        }
    }
}
