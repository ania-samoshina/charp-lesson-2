using System;

namespace Task4
{
    //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, 
    //если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод 
    //проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает 
    //его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
    public class Auto
    {
        public static void Authorization()
        {

            string login = "root";
            string password = "GeekBrains";
            int count = 0;
            bool logpas;
            do
            {
                Console.Write("Enter login: ");
                string l = Console.ReadLine();
                Console.Write("Enter password: ");
                string p = Console.ReadLine();

                if (l == login && p == password)
                {
                    Console.WriteLine($"Аuthorization passed! {logpas = true}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Authorization failed! {logpas = false}");
                    count++;
                }


                      } while (count < 3);

        }
    }
}
