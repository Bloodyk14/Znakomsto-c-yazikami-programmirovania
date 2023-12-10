/*Задача 1: Задайте двумерный массив символов (тип char
[,]). Создать строку из символов этого массива.*/


char[,] array = new char[,] {
            { 'T', 'E', 'U' },
            { 'T', 'L', 'O' },
            { 'H', '1', 'C' }
        };

Console.WriteLine(GetCharToString(array));

string GetCharToString(char[,] work)
{
    string str = string.Empty;
    int rows = work.GetLength(0);
    int cols = work.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            str += work[i, j];
        }
    }
    return str;
}