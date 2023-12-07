/*Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.*/



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    //Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
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

void ChangeArray(int[,] newArray)
{
for (int i = 0; i < newArray.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < newArray.GetLength(1); j = j + 1)
        {
        newArray[i, j] = newArray [i, j] * newArray[i, j];
        }
       
    }
}

int[,] newArray = GetArray(3, 3, 5, 10); 
PrintArray(newArray);
ChangeArray(newArray);
Console.WriteLine();
PrintArray(newArray);