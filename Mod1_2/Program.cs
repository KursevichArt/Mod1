using System;
using static System.Console;

namespace Mod1_2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                WriteLine("Введите целое число:");
                int numb = Convert.ToInt32(ReadLine());

                if (numb == 0)
                {
                    WriteLine("Вы ввели ноль");
                    WriteLine("Хотите выполнить еще одно преобразование? (Y для продолжения, любой другой символ для выхода):");
                    char choice = ReadKey().KeyChar;
                    WriteLine();

                    if (choice != 'Y' && choice != 'y')
                       break;
                    continue;
                }

                if (numb % 2 == 0)
                    WriteLine($"{numb} является чётным числом.");
                else
                    WriteLine($"{numb} является не чётным числом.");

                WriteLine("Хотите выполнить еще одно преобразование? (Y для продолжения, любой другой символ для выхода):");
                char ContChoice = ReadKey().KeyChar;
                WriteLine();

                if (ContChoice != 'Y' && ContChoice != 'y')
                   break;
            }
            WriteLine("Программа завершена.");
        }
    }
}