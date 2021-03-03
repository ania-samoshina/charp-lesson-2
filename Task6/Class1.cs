using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Task6
{
    //*написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    //«хорошим» называется число, которое делится на сумму своих цифр. реализовать подсчёт времени 
    //выполнения программы, используя структуру datetime.
    public class MainClass
    {
        private static long SumOfDigits(long number)
        {
            long sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }


        private static bool IsGoodNumber(long number)
        {
            return (number % SumOfDigits(number)) == 0;
        }

        public static void Main()
        {
            long from = 1;
            long to = 1000000000;

            int count = 0;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (long i = from; i <= to; i++)
            {
                if (IsGoodNumber(i))
                {
                    count++;
                }
                //Console.Write($"\rРаботаю! Я посчитал уже {(double)i / (double)to * 100.0:N5} процентов");
            }

            stopWatch.Stop();

            Console.WriteLine($"Good numbers count {count}");

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
              ts.Hours, ts.Minutes, ts.Seconds,
              ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}


