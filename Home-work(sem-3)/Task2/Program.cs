/*Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.*/


double[] numbers = {3.14, 2.71, 5.55, 7.77, 1.25};


double max = numbers[0]; 
double min = numbers[0]; 

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

double difference = max - min;

 Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    