/*Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2 */ 


using System;

class Program
{
    static void Main()
    {
        int[] userArray = GetNewArray();
        PrintArray(userArray);
        var results = CheckNumbers(userArray);

        Console.WriteLine("Числа, заканчивающиеся на 1 и делящиеся на 7 без остатка:");
        foreach (var number in results)
        {
            Console.WriteLine(number);
        }
    }

    static int[] GetNewArray()
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] newArray = new int[size];

        Console.WriteLine("Введите числа для массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            newArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        return newArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int[] CheckNumbers(int[] array)
    {
        int[] results = new int[array.Length];
        int count = 0;

        foreach (var number in array)
        {
            if (number % 10 == 1 && number % 7 == 0)
            {
                results[count++] = number;
            }
        }

        // Создание нового массива с количеством элементов, соответствующим значению count
        int[] finalResults = new int[count];
        for (int i = 0; i < count; i++)
        {
            finalResults[i] = results[i];
        }
        return finalResults;
    }
}

