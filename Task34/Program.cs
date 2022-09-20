// Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива: ");


int siseArray = 0;
int count = 0;
//  int siseArray = int.Parse(Console.ReadLine());


try
{

    siseArray = int.Parse(Console.ReadLine());
}
catch (System.FormatException)
{
    Console.WriteLine("Введите число!");
    Console.WriteLine(" ");
    throw;
}

int[] getRandomArray()
{
    int[] array = new int[siseArray];
    Random random = new Random();

    for (int i = 0; i < siseArray; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void outResultConsole(int[] array)
{
    for (int i = 0; i < siseArray; i++)
    {
        if (array[i] % 2 == 0)
        {
            // System.Console.Write(array[i]);
            // System.Console.Write(" ");
            count++;
        }
    }
    Console.Write($"Количество четных чисел {count} в массиве из {siseArray} чисел: ");
}

outResultConsole(getRandomArray());