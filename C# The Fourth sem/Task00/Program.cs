/*Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.
Примеры
[1 3 4 19 60] => 2
[4 3 4 1 9 5 21 13] => 3 */

class Program
{
    static int Workwithuser(string message)
    {
        Console.Write(message);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    static int[] GetNewArray(int len, int minValue, int maxValue)
    {
        int[] newArray = new int[len];
        Random rnd = new Random();
        for (int i = 0; i < len; i++)
        {
            newArray[i] = rnd.Next(minValue, maxValue);
        }
        return newArray;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }

    static int GetCountNormalNumber(int[] array)
    {
        int countOfPrimes = 0; // Переменная для подсчета простых чисел

        foreach (var number in array)
        {
            bool isPrime = true; // Флаг, определяющий является ли число простым

            if (number <= 1)
                isPrime = false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                countOfPrimes++;
        }
        return countOfPrimes;
    }

    static void Main(string[] args)
    {
        int size = Workwithuser("Введите размер массива: ");
        int min = Workwithuser("Введите минимальное значение: ");
        int max = Workwithuser("Введите максимальное значение: ");
        int[] array = GetNewArray(size, min, max);

        int countOfPrimes = GetCountNormalNumber(array);
        Console.WriteLine($"Количество простых чисел в массиве: {countOfPrimes}");
    }
}
