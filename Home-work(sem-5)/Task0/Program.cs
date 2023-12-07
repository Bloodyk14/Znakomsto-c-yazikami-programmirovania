/*Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/ 

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

string GetElementValue(int[,] array, int row, int column)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    // Проверяем, находится ли позиция в пределах массива
    if (row >= 0 && row < rows && column >= 0 && column < columns)
    {
        return $"Значение элемента [{row},{column}]: {array[row, column]}";
    }
    else
    {
        return "Такого элемента нет в массиве.";
    }
}

int[,] userArray = GetUserInputArray(3, 3);

PrintArray(userArray); 
Console.WriteLine();

string elementInfo = GetElementValue(userArray, 1, 1); // Получение информации о значении элемента [1,1]
Console.WriteLine(elementInfo); // Вывод результата работы GetElementValue


