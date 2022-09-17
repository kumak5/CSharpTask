// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Введите размер массива: ");


int sizeArray = 0;


try
{

    sizeArray = int.Parse(Console.ReadLine());
}
catch (System.FormatException)
{
    Console.WriteLine("Введите число!");
    Console.WriteLine(" ");
    throw;
}

int[] getRandomArray()
{
    int[] array = new int[sizeArray];
    Random random = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = random.Next(0, 1000);
    }

    return array;
}

int differenceNumberInArray(int[] array)
{

    int first = array[0];
    int second = array[sizeArray - 1];
    int arrayDifference;
    if (array[0] > array[sizeArray - 1])
    {
        arrayDifference = array[0] - array[sizeArray - 1];
    }
    else
    {
        arrayDifference = array[sizeArray - 1] - array[0];
    }
    Console.WriteLine($"Первое число: {first}");
    Console.WriteLine($"Второе число: {second}");
    return arrayDifference;
}

void outputResultConsole(int arrayDifference)
{

    Console.Write($"Разница между первым и последним чисвлом в массиве из {sizeArray} чисел:  {arrayDifference} ");

    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

outputResultConsole(differenceNumberInArray(getRandomArray()));
