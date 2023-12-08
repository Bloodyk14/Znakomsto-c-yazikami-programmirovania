/*Задача 2: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

int[,] GetUserInputArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Введите значение для элемента [{i},{j}]: ");
            if (!int.TryParse(Console.ReadLine(), out array[i, j]))
            {
                Console.WriteLine("Некорректный ввод! Попробуйте еще раз.");
                j--; // Повторяем запрос для текущего элемента
            }
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SwapFirstAndLastRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    // Проверка, что в массиве есть хотя бы две строки
    if (rows >= 2)
    {
        for (int j = 0; j < columns; j++)
        {
            int temp = array[0, j];
            array[0, j] = array[rows - 1, j];
            array[rows - 1, j] = temp;
        }
    }
    else
    {
        Console.WriteLine("Массив имеет меньше двух строк. Невозможно выполнить замену.");
    }
}

int[,] userArray = GetUserInputArray(3, 3);

Console.WriteLine("Исходный массив:");
PrintArray(userArray);
Console.WriteLine();

SwapFirstAndLastRows(userArray);
Console.WriteLine("Массив с измененными положениями первого и последнего элемента:");
PrintArray(userArray);

