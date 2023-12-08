/*Задача 3: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int[,] WorkWithUser(int rows, int columns)
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

int FindRowWithMinElem(int[,] array)
{
    int minSum = int.MaxValue;
    int rowIndex = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowIndex = i;
        }
    }

    return rowIndex;
}


int[,] userArray = WorkWithUser(6, 3);
Console.WriteLine("Ваш прямоугольный массив:");
PrintArray(userArray);
Console.WriteLine();

int rowIndex = FindRowWithMinElem(userArray);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {rowIndex}");

Console.WriteLine("Строка с наименьшей суммой элементов:");
for (int j = 0; j < userArray.GetLength(1); j++)
{
    Console.Write($"{userArray[rowIndex, j]} ");
}