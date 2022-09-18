// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите 4 числа: ");


double b1;
double b2;
double k1;
double k2;
double x, y;

try
{
     b1 = int.Parse(Console.ReadLine());
     k1 = int.Parse(Console.ReadLine());
     b2 = int.Parse(Console.ReadLine());
     k2 = int.Parse(Console.ReadLine());
}
catch (System.Exception)
{
    Console.WriteLine("Введите число!");
    throw;
}

x = (b1-b2)/(k2-k1);
y = k2*x+b2;

Console.WriteLine($"Результат : {x} {y}");