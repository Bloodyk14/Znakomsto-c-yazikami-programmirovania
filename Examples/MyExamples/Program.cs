using System;

class Program
{
    static void Main()
    {
        string originalString = "abcdefghijklmnopqrstuvwxyz";

        // Номера символов для формирования строки "Sasha LOX"
        int[] charIndexes = { 18, 0, 18, 7, 0, -1, 11, 14, 23 };

        // Преобразовываем номера символов в строку
        string result = TransformIndexesToString(originalString, charIndexes);

        // Выводим результат
        Console.WriteLine(result);
    }

    static string TransformIndexesToString(string input, int[] indexes)
    {
        char[] resultArray = new char[indexes.Length];
        for (int i = 0; i < indexes.Length; i++)
        {
            // Если индекс не равен -1, преобразуем символ
            if (indexes[i] != -1 && indexes[i] < input.Length)
            {
                resultArray[i] = input[indexes[i]];
            }
            // В противном случае оставляем символ пробела
            else
            {
                resultArray[i] = ' ';
            }
        }

        return new string(resultArray);
    }
}