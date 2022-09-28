// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine(" ");
// Console.WriteLine("Массив до сортировки: ");

int line = 4;
int column = 6;
int[,] array = new int[line, column];
// int[] arrayInLine = new int[column];
int minSumInLine = 0;
int lineIndex = 0;

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < line; i++)
{
    int sum = 0;
    for (int j = 0; j < column; j++)
    {
        sum = sum + array[i, j];
        Console.Write(array[i, j]);
    }

    Console.Write("  =  ");
    Console.Write(sum);
    Console.WriteLine(" ");

    if (minSumInLine < sum)
    {
        minSumInLine = sum;
        lineIndex = i;
    }
    Console.WriteLine(" ");
}

Console.WriteLine($"линия {lineIndex + 1}, сумма: {minSumInLine} ");
