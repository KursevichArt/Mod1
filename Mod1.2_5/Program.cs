using System;
using static System.Console;
using System.Linq;

namespace Mod1._2_5
{
    class Program
    {
        static void Main()
        {
            // Ввод значения K с клавиатуры
            Write("Введите количество элементов массива K: ");
            int K = int.Parse(ReadLine());

            // Определение русского алфавита
            char[] russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

            // Создание и заполнение символьного массива случайными буквами русского алфавита
            char[] charArray = new char[K];
            Random rand = new Random();

            for (int i = 0; i < K; i++)
                charArray[i] = russianAlphabet[rand.Next(russianAlphabet.Length)];

            // Определение согласных букв
            char[] consonants = "бвгджзйклмнпрстфхцчшщ".ToCharArray();

            // Создание нового массива только с согласными буквами
            char[] consonantArray = charArray.Where(c => consonants.Contains(c)).ToArray();

            // Вывод исходного массива
            WriteLine("Исходный массив: " + string.Join(", ", charArray));

            // Вывод массива с согласными буквами
            WriteLine("Массив согласных букв: " + string.Join(", ", consonantArray));
        }
    }
}