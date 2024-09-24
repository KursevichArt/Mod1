using System;
using static System.Console;

namespace Mod1._2_4
{
    class Program
    {
        static void Main()
        {
            // Входные данные
            int K = 10; // Количество элементов в массиве
            int A = 1;  // Начало диапазона
            int B = 100; // Конец диапазона (не включительно)

            // Создание и заполнение массива случайными значениями
            int[] array = new int[K];
            Random rand = new Random();

            for (int i = 0; i < K; i++)
                array[i] = rand.Next(A, B);

            // Поиск индексов минимального и максимального элементов
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < K; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            // Определение начального и конечного индексов для вывода
            int startIndex = Math.Min(minIndex, maxIndex);
            int endIndex = Math.Max(minIndex, maxIndex);

            // Вывод значений массива
            WriteLine("Исходный массив: " + string.Join(", ", array));
            WriteLine($"Минимальный элемент: array[{minIndex}] = {array[minIndex]}");
            WriteLine($"Максимальный элемент: array[{maxIndex}] = {array[maxIndex]}");
            Write("Элементы между минимальным и максимальным (включительно): ");

            for (int i = startIndex; i <= endIndex; i++)
                Write(array[i] + (i < endIndex ? ", " : "\n"));
        }
    }
}