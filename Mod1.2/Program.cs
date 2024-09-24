using System;
using static System.Console;

namespace Mod1._2
{
    class Program
    {
        static void Main()
        {
            // Вводим размер массива
            Write("Введите размер массива N: ");
            int N = int.Parse(ReadLine());

            // Создаем массив заданного размера
            double[] array = new double[N];

            // Вводим значения элементов массива
            for (int i = 0; i < N; i++)
            {
                Write($"Введите элемент {i + 1}: ");
                array[i] = double.Parse(ReadLine());
            }

            // Находим максимальный по модулю элемент массива
            double maxAbsoluteValue = Math.Abs(array[0]);
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(array[i]) > maxAbsoluteValue)
                   maxAbsoluteValue = Math.Abs(array[i]);
            }

            // Нормируем элементы массива
            for (int i = 0; i < N; i++)
               array[i] /= maxAbsoluteValue;
         
            // Выводим измененные элементы массива
            WriteLine("Измененные значения элементов массива:");
            foreach (double value in array)
            WriteLine(value);
        }
    }
}