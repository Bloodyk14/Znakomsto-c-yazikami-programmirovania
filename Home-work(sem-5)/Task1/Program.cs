/*Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
using System;

class Program
{
    static int[] GenerateRanArr(int size)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10); // Генерация трёхзначных чисел
        }

        return array;
    }

    static void DisplayArrAndCou(int[] array, int count)
    {
        Console.WriteLine("Массив случайных трёхзначных чисел:");
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine($"\nКоличество чётных чисел: {count}");
    }

 static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }


    static void Main()
    {
       int size = 10; // Размер массива

        int[] randomArray = GenerateRanArr(size);
        int countOfEvenNumbers = CountEvenNumbers(randomArray);

        DisplayArrAndCou(randomArray, countOfEvenNumbers);
    }

}