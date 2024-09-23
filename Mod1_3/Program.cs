using System;
using static System.Console;

namespace Mod1_3
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                WriteLine("Введите строку для проверки на палиндром.");
                string input = ReadLine();

                string processedInput = input.Replace(" ", "").ToLower();

                if (IsPalindrome(processedInput))
                    WriteLine($"'{input}' является палиндромом.");
                else
                    WriteLine($"'{input}' не является палиндромом.");

                WriteLine("Хотите проверить другую строку? (Y для продолжения, любой другой символ для выхода):");
                char choice = ReadKey().KeyChar;
                WriteLine();

                if (choice != 'Y' && choice != 'y')
                   break; // Выход из цикла и завершение программы
                
            }
            WriteLine("Программа завершена.");
        }

        // Метод для проверки на палиндром
        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                   return false; // Строка не является палиндромом
                
                left++;
                right--;
            }
            return true; // Строка является палиндромом
        }
    }
}