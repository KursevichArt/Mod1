using System;
using static System.Console;

namespace Mod1._2_2
{
    class Program
    {
        static void Main()
        {
            // Определяем и инициализируем массив из 10 элементов
            int[] array = { 10, 3, -5, 7, 2, -9, 12, 4, -1, 6 };

            // Выводим исходный массив
            WriteLine("Исходный массив:");
            foreach (int value in array)
            {
                Write(value + " ");
            }
            WriteLine();

            // Вводим новое значение
            Write("Введите целое число для замены максимального элемента: ");
            int newValue = int.Parse(ReadLine());

            // Находим индекс максимального элемента
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Заменяем максимальный элемент на введенное значение
            array[maxIndex] = newValue;

            // Выводим измененный массив
            WriteLine("Измененный массив:");
            foreach (int value in array)
            {
                Write(value + " ");
            }
            WriteLine();
        }
    }
}