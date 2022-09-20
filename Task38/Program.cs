// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Введите размер массива: ");


int sizeArray = 0;
int max = 0;
int min = 0;

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
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];

        if (array[i] > max) max = array[i];
    }


    // int first = array[0];
    // int second = array[sizeArray - 1];
    int numberDifference = max - min;

    return numberDifference;
}

void outputResultConsole(int namberDifference)
{

    Console.Write($"Разница между максимальным и минимальным чисвлом в массиве из {sizeArray} чисел:  {namberDifference} ");

    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

outputResultConsole(differenceNumberInArray(getRandomArray()));
