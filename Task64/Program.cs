// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


int n = 0;
Console.WriteLine("Введите число: ");


try
{
    n = int.Parse(Console.ReadLine());
}
catch (System.Exception)
{
    Console.WriteLine("Введите число.");
    throw;
}

void nNumber(int n)
{
    int k = 0;
    Console.Write($"N = 5 -> \" ");
    for (int i = 0; i < n; i++)
    {
        k = n - i;
        Console.Write($"{k} ");
    }
    Console.Write($"\"");
}

nNumber(n);
