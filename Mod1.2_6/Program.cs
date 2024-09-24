using System;
using static System.Console;
using System.Linq;

namespace Mod1._2_6
{
    class Program
    {
        static void Main()
        {
            // Определяем количество элементов в массиве
            int n = 10;

            // Создаем массив вещественных чисел и заполняем случайными значениями
            double[] array = new double[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                array[i] = rand.NextDouble() * 20 - 10; // Генерация случайного числа в диапазоне [-10, 10)

            // Создаем массив индексов, отсортированных по значениям основного массива
            int[] indexArray = array
                .Select((value, index) => new { Value = value, Index = index }) // Создаем анонимные объекты с элементом и его индексом
                .OrderBy(x => x.Value) // Сортируем по значению элементов
                .Select(x => x.Index) // Получаем только индексы
                .ToArray();

            // Вывод исходного массива
            WriteLine("Исходный массив: " + string.Join(", ", array.Select(x => x.ToString("F2"))));

            // Вывод массива индексов
            WriteLine("Массив индексов (по возрастанию значений): " + string.Join(", ", indexArray));
        }
    }
}