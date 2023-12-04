/* Задача 1: Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная.*/

using System;

class Program
{
    static bool IsSumEven(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += Math.Abs(number % 10); // Получаем последнюю цифру и добавляем ее к сумме
            number /= 10; // Удаляем последнюю цифру числа
        }

        return sum % 2 == 0; // Проверяем, является ли сумма четной
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            int number;
            bool isNumeric = int.TryParse(input, out number);

            if (isNumeric)
            {
                if (IsSumEven(Math.Abs(number)))
                {
                    Console.WriteLine("Сумма цифр числа четная. Выход из программы.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода.");
            }
        }
    }
}