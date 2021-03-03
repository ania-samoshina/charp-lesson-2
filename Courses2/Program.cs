using System;

namespace Courses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print.Class1.PrintName("Ann Samoshina");
            Console.WriteLine("Enter your task: ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Task1.Min.Min1();
                    break;
                case 2:
                    Task2.NOD.NumberOfDigits();
                    break;
                case 3:
                    Task3.OPN.OddPositiveNumbers();
                        break;
                case 4:
                    Task4.Auto.Authorization();
                    break;
                case 5:
                    Task5.Weight.Run();
                    break;
                case 6:
                    Task6.MainClass.Main();
                    break;
                case 7:
                    Task7.Class1.Metod();
                    break;
            }
            Console.ReadKey();

        }
    }
}
