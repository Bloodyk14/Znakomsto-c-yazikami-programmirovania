/*Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д.
Пр имер
 23 4 3
 4 3 4 1 => 2 + 3 + 5 = 10
 2 9 5 4*/

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
         array[i, j] = rand.Next(min, max);  
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

int GetSumOfMainDiagonal(int[,] array)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i == j)
            {
                sum += array[i, j]; // Суммируем элементы на главной диагонали
            }
        }
    }

    return sum;
}


int [,] newArray = GetArray(3, 4, 1, 9);
PrintArray(newArray);
Console.WriteLine();

int sumOfDiagonal = GetSumOfMainDiagonal(newArray);
Console.Write("");
for (int i = 0; i < newArray.GetLength(0); i++)
{
    Console.Write($"{newArray[i, i]}");
    if (i < newArray.GetLength(0) - 1)
    {
        Console.Write(" + ");
    }
}
Console.WriteLine($" => {sumOfDiagonal}");


