using System;
using static System.Console;

namespace Mod1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                WriteLine("Введите температуру:");
                double temperature = Convert.ToDouble(ReadLine());

                WriteLine("Выберите единицу измерения (C для Цельсия, F для Фаренгейта):");
                char unit = ReadKey().KeyChar;
                WriteLine();

                switch (unit)
                {
                    case 'C':
                    case 'c':
                        double fahrenheit = (temperature * 9 / 5) + 32;
                        WriteLine($"{temperature}°C = {fahrenheit}°F");
                        break;

                    case 'F':
                    case 'f':
                        double celsius = (temperature - 32) * 5 / 9;
                        WriteLine($"{temperature}°F = {celsius}°C");
                        break;

                    default:
                        WriteLine("Неверная единица измерения. Пожалуйста, введите C или F.");
                        continue; // Возвращаемся к началу цикла, если введена неверная единица измерения
                }

                WriteLine("Хотите выполнить еще одно преобразование? (Y для продолжения, любой другой символ для выхода):");
                char choice = ReadKey().KeyChar;
                WriteLine(); // Для новой строки

                if (choice != 'Y' && choice != 'y')
                   break; // Прерываем цикл и завершаем программу, если пользователь не ввел 'Y'
                
            }
            WriteLine("Программа завершена.");
        }
    }
}