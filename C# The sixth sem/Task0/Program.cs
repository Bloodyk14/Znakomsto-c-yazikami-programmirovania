/*Задайте массив символов (тип char []). Создайте строку из
символов этого массива.*/

char[] array = new char[] { 'a', 'b', 'c', 'd' };
char[] array2 = new char[] { 'n', 'r', 'm', 'w', 'x', };
string str = string.Empty; //Задается пустая строка 
Console.WriteLine(GetCharToString(array));
Console.Write(GetCharToString(array2));

string GetCharToString(char[] arr)
{
    string str = string.Empty; //Задается пустая строка 
    for (int i = 0; i < arr.Length; i++)
    {
        str += arr[i];
    }
    return str;
}
