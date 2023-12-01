/* Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7] */

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int[] digitArray = new int[3]; // Создание массива для хранения цифр

for (int i = digitArray.Length - 1; i >= 0; i--)
{
    digitArray[i] = num % 10; // Получение последней цифры числа и сохранение в массиве
    num /= 10; // Удаление последней цифры из числа
}

// Меняем элементы местами для получения правильной последовательности
int temp = digitArray[0];
digitArray[0] = digitArray[2];
digitArray[2] = temp;

// Вывод массива цифр числа

Console.WriteLine("Массив цифр числа:");
for (int i = 0; i < digitArray.Length; i++)
{
    Console.Write(digitArray[i] + "/");
}
