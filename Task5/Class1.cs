using System;

namespace Task5
{
    //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
    //нужно ли человеку похудеть, набрать вес или всё в норме.
    //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    public class Weight
    {
        public static double GetWeightDelta(double height, double weight)
        {
            double normalWeight = height * 0.7 - 50;
            double delta = normalWeight - weight;
            return delta;
        }


        public static void Run()
        {
            Console.Write("Enter height in metrs: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double result = weight / (height * height);
            Console.Write("Body mass index: ");
            Console.WriteLine($"{result,3:F5}");
            double h = height * 100;

            switch (result)
            {
                case double mi when (mi < 16):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Severe underweight!");
                        Console.WriteLine($"You need to dial {resultWeight}");
                        break;
                    }
                case double mi when (mi >= 16 && mi < 18.5):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Insufficient (deficiency) body weight!");
                        Console.WriteLine($"You need to dial {resultWeight}");
                        break;
                    }
                case double mi when (mi >= 18.5 && mi < 25):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Normal weight");
                        break;
                    }
                case double mi when (mi >= 25 && mi < 30):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Overweight (pre-obesity)!");
                        Console.WriteLine($"You need to lose weight by {resultWeight}");
                        break;
                    }
                case double mi when (mi >= 30 && mi < 35):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Obesity!");
                        Console.WriteLine($"You need to lose weight by {resultWeight}");
                        break;
                    }
                case double mi when (mi >= 35 && mi < 40):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Obesity is sharp!");
                        Console.WriteLine($"You need to lose weight by {resultWeight}");
                        break;
                    }
                case double mi when (mi >= 40):
                    {
                        double resultWeight = GetWeightDelta(h, weight);
                        Console.WriteLine("Very severe obesity!");
                        Console.WriteLine($"You need to lose weight by {resultWeight}");
                        break; 
                    }
               
            }
            Console.ReadKey();


        }

    }
}
