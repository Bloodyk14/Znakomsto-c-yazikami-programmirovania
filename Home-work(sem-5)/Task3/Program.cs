/*Задача 4* Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых, 
расположен наименьший элемент массива.
Под удалением понимается создание нового двумерного массива без строки и столбца*/

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

int[,] RemoveRowAndColumnWithMinElement(int[,] array)
{
    int minElement = array[0, 0];
    int minRow = 0;
    int minColumn = 0;

    // Находим наименьший элемент и его индексы
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    // Создаем новый массив без строки и столбца с минимальным элементом
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int newRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minRow) continue;

        int newColumn = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minColumn) continue;

            newArray[newRow, newColumn] = array[i, j];
            newColumn++;
        }

        newRow++;
    }

    return newArray;
}

int[,] userArray = WorkWithUser(3, 3);
Console.WriteLine("Ваш изначальный массив:");
PrintArray(userArray);
Console.WriteLine();

int[,] newArray = RemoveRowAndColumnWithMinElement(userArray); // Получаем новый массив
Console.WriteLine("Ваш новый массив:");
PrintArray(newArray); // Выводим новый массив