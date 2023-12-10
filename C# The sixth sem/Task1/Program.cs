/*На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание
Метод строки ToCharArray() не использовать.*/

string str = "Hello world";

char[] ChangeStringToChar(string str)
{
    char[] array = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = str[i];
    }
    return array;
}

Console.WriteLine(String.Join(",", ChangeStringToChar(str)));

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