// Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива: ");


int siseArray = 0;

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
    Console.Write($"Массив из {siseArray} чисел: ");
    for (int i = 0; i < siseArray; i++)
    {
        System.Console.Write(array[i]);
        System.Console.Write(" ");
    }
}

outResultConsole(getRandomArray());