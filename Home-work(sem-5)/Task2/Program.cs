/*Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)*/

using System;

class Program
{
    static void Main()
    {
        int [] mainArray = {0, 1, 2, 3, 4, 5};

        Console.WriteLine("Исходный массив: ");
        DisplayArray(mainArray);

        int [] reversedArray = ReverseArray(mainArray);
        
        Console.WriteLine("Перевернутый массив: ");
        DisplayArray(reversedArray);
    }

    static void DisplayArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static int[] ReverseArray(int[] arr)
    {
        int length = arr.Length;
        int[] reversed = new int[length];

        // Переворачиваем массив, меняя местами элементы
        for (int i = 0; i < length; i++)
        {
            reversed[i] = arr[length - 1 - i];
        }

        return reversed;
    }
}