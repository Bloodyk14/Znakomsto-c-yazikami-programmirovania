/*Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.*/

void WorkWithUser()
{
    Console.WriteLine("Введите значение M:");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int N = Convert.ToInt32(Console.ReadLine());

    FinalResult(M, N);

}

void PrintNumbers(int M, int N)
{

    if (M < 1)
    {
        M = 1;
    }

    if (M > N)
    {
        return;
    }

    Console.WriteLine(M);
    PrintNumbers(M + 1, N);
}

void FinalResult(int M, int N)
{
    Console.Write($"Натуральные числа от {M} до {N}:");
    Console.WriteLine();
    PrintNumbers(M, N);
}

WorkWithUser();