using System;

namespace Semenar2_CSharp_Start
{
    
    class Semestr2
    {
        static void Main(string[] args)
        {
            /* Задача 2: Напишите программу, которая выводит
            случайное трёхзначное число и удаляет вторую цифру
            этого числа.
            456-> 46
            782-> 72
            918-> 98
            Задача 3: Напишите программу, которая выводит третью
            цифру заданного числа или сообщает, что третьей цифры
            нет.
            645-> 5
            78->третьей цифры нет
            32679-> 6
            Задача 4: Напишите программу, которая принимает на
            вход цифру, обозначающую день недели, и проверяет,
            является ли этот день выходным.
            6->да
            7->да
            1->нет */

            // Задача 2:Решение

            Random rnd = new Random();
            int task2 = rnd.Next(100, 999);

            Console.WriteLine("Задача 2: Напишите программу, которая выводит " +
            "случайное трёхзначное число и удаляет вторую цифру " +
            "этого числа. Решение:");
            Console.WriteLine(task2 + "-> " + task2 / 10 + "\n\n");


            // Задача 3:Решение

            Console.WriteLine("Задача 3: Напишите программу, которая выводит третью " +
            "цифру заданного числа или сообщает, что третьей цифры " +
            "нет. Введите число:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int numberTask3);
            int task3 = 0;

            if (numberCheck)
            {
                if (numberTask3 > 99)
                {
                    while (numberTask3 > 99)
                    {
                        task3 = numberTask3 % 10;
                        numberTask3 /= 10;
                    }
                    Console.WriteLine("-> " + task3);
                }
                else Console.WriteLine("->третьей цифры нет");

            }
            else Console.WriteLine("->третьей цифры нет");

            // Задача 4:Решение

            Console.WriteLine("Задача 4: Напишите программу, которая принимает на " +
            "вход цифру, обозначающую день недели, и проверяет, " +
            "является ли этот день выходным. Введите число:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task4);

            if (numberCheck)
            {
                if (task4 > 0 && task4 < 8)
                {
                    if (task4 > 5)
                        Console.WriteLine("да");
                    else
                        Console.WriteLine("нет");
                }
                else Console.WriteLine("нет такого дня недели");
            }
            else Console.WriteLine("не число");
        }
    }
}
