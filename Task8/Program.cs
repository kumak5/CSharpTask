﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write($"Введите число:");
Console.Write($" ");

int number1 = int.Parse(Console.ReadLine());

Console.Write($"четные числа от 1 до {number1}: ");

for (int i = 1; i < number1; i++)
{
    
    if ((i % 2) == 0)
    {
        Console.Write($"{i} ");
    }

}
