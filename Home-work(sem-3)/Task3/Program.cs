/*Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
Размер массива должен быть равен количеству цифр.*/

Console.WriteLine("Введите натуральное число от 1 до 100000:");
int number = int.Parse(Console.ReadLine());

// Определяем количество цифр в числе
int count = 0;
int temp = number;
while (temp > 0)
{
    temp /= 10;
    count++;
}

int[] digits = new int[count];
temp = number;

for (int i = count - 1; i >= 0; i--)
{
    digits[i] = temp % 10;
    temp /= 10;
}

Console.WriteLine("Массив цифр числа:");
foreach (int digit in digits)

    Console.Write(digit + " ");