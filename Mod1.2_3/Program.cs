using System;
using static System.Console;

namespace Mod1._2_3
{
    class Program
    {
        static void Main()
        {
            // Вводим значение K
            Write("Введите количество простых чисел K: ");
            int K = int.Parse(ReadLine());

            // Проверяем, что значение K больше 0
            if (K <= 0)
            {
                WriteLine("Количество простых чисел должно быть положительным.");
                return;
            }

            // Переменные для поиска простых чисел
            int count = 0; // Счетчик найденных простых чисел
            int number = 2; // Начальное число для проверки

            // Цикл поиска и вывода простых чисел
            while (count < K)
            {
                if (IsPrime(number))
                {
                    // Выводим число и увеличиваем счетчик найденных простых чисел
                    Write(number + "\t");
                    count++;

                    // Переход на новую строку каждые 10 чисел
                    if (count % 10 == 0)
                       WriteLine();
                }
                number++; // Переходим к следующему числу
            }
        }

        // Метод для проверки, является ли число простым
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                   return false;
            }
            return true;
        }
    }
}