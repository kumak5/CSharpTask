// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.WriteLine(" ");
Console.WriteLine("Массив до сортировки: ");

int line = 4;
int column = 6;
int[,] array = new int[line, column];
int[] arrayInLine = new int[column];


for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine(" ");
}
Console.WriteLine(" ");
Console.WriteLine("Массив после сортировки: ");

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        arrayInLine[j] = array[i, j];
    }

    Array.Sort(arrayInLine);
    Array.Reverse(arrayInLine);

    for (int j = 0; j < column; j++)
    {
        array[i, j] = arrayInLine[j];
    }
}

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine(" ");
}
