// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты двух точек в 3-х осевой коодинатной системе: ");
Console.WriteLine("первая точка: ");


int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("вторая точка: ");

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Round((Math.Sqrt(Math.Pow((x2 - x1), 2) +
                            Math.Pow((y2 - y1), 2) +
                            Math.Pow((z2 - z1), 2))), 2);


Console.WriteLine($"Растояние от точки до точки в пространстве: {result}");