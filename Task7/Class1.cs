using System;

namespace Task7
{
    //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

    public class Class1
    {
       
        
            public static void PrintFromAtoB(int a, int b)
            {
            Console.WriteLine(a);
            if (a < b) PrintFromAtoB(++a, b);
           // else Console.WriteLine(b);
                           
            }
        public static int SummFromAtoB(int a, int b)
        {
            if (a == b) return b;
            else return a + SummFromAtoB(++a, b);

  

        }

        public static void Metod()
        {
            Console.WriteLine("Recursive inference method from a to b:");
            PrintFromAtoB(1, 5);
            Console.Write($"Summa from a to b: {SummFromAtoB(1, 5)} ");
        }
        
    }
}
