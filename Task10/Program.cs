// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите три числа:");
int number = int.Parse(Console.ReadLine());
int numberPosition2 =(number/10)%10;

Console.WriteLine($"Второе число: {numberPosition2}");

