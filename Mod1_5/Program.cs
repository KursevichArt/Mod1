using System;
using static System.Console;

namespace Mod1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int rand = random.Next(1, 11);
                WriteLine("Попробуйте угадать задуманное мной число от 1 до 10.");
                int numb = Convert.ToInt32(ReadLine());

                if (numb == rand)
                    WriteLine($"{numb} вы угадали!");
                else
                    WriteLine("Неправильно, попробуйте ещё раз!");

                WriteLine("Хотите проверить другую строку? (Y для продолжения, любой другой символ для выхода):");
                char choice = ReadKey().KeyChar;
                WriteLine();

                if (choice != 'Y' && choice != 'y')
                    break; // Выход из цикла и завершение программы
            }
        }
    }
}