/*Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

static void ReverseArray(int[] array, int startIndex, int endIndex)
{
    if (startIndex >= endIndex)
        return;

    int temp = array[startIndex];
    array[startIndex] = array[endIndex];
    array[endIndex] = temp;

    ReverseArray(array, startIndex + 1, endIndex - 1);
}

int[] mainArray = { 2, 3, 4, 5, 6, 7, 8 };
Console.Write("Исходный массив: ");
foreach (int number in mainArray)
{
    Console.Write(number + " ");
}

ReverseArray(mainArray, 0, mainArray.Length - 1);

Console.Write("\nПеревернутый массив: ");
foreach (int number in mainArray)
{
    Console.Write(number + " ");
}

