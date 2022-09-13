// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. Элементы массива вводятся пользователем.

Console.WriteLine("Введите восемь чисел: ");

void PrintArrayToConsole(int[] array)
{
    Console.Write("Массив из восьми чисел: ");
    for (int i = 0; i < 8; i++)
    {
        System.Console.Write(array[i]);
        System.Console.Write(" ");
    }
}

try
{
    int[] arrayDigits = new int[8];

    for (int i = 0; i < 8; i++)
    {
        arrayDigits[i] = int.Parse(Console.ReadLine());
    }

    PrintArrayToConsole(arrayDigits);
}
catch (System.Exception)
{

    throw;
}