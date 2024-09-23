using System;
using static System.Console;

namespace Mod1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                   // Создаем массив из 5 названий городов
                   string[] cities = { "Орша", "Витебск", "Минск", "Гродно", "Борисов" };
                   
                   // Запрашиваем у пользователя название города
                   WriteLine("Введите название города для поиска:");
                   string userInput = ReadLine();
                   
                   // Поиск индекса города в массиве
                   int index = Array.IndexOf(cities, userInput);
                   
                   if (index >= 0)
                      // Город найден, выводим его индекс
                      WriteLine($"Город '{userInput}' найден в массиве на позиции {index}.");
                   else
                      // Город не найден
                      WriteLine($"Город '{userInput}' не найден в массиве.");
                    
                   WriteLine("Хотите проверить другую строку? (Y для продолжения, любой другой символ для выхода):");
                   char choice = ReadKey().KeyChar;
                   WriteLine();

                   if (choice != 'Y' && choice != 'y')
                      break; // Выход из цикла и завершение программы
                
            }
        }
    }
}
