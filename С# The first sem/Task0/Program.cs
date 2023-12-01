// Напишите программу, которая на вход принимает два целых числа и проверяет,
//является ли первое число квадратом второго.

// // a = 25, b = 5 => да
// // a = 2, b = 10 => нет
// // a = 9, b = -3 => да
// // a = -3, b = 9 => нет

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 * number2== number)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}