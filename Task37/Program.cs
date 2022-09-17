// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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
        array[i] = random.Next(-999, 1000);
    }
    return array;
}

int[] multiplicationNumberInArray(int[] array)
{
    int size = sizeArray / 2;
    int[] arrayMultiplication = new int[size];
    for (int i = 0; i < (size); i++)
    {
        arrayMultiplication[i] = array[i] * array[sizeArray - 1 - i];
    }
    return arrayMultiplication;
}

void outputResultConsole(int[] arrayMultiplication)
{
    Console.Write($"Массив произведения пар чисел из массива размером {sizeArray} чисел:  ");
    for (int i = 0; i < arrayMultiplication.Length; i++)
    {
        System.Console.Write(arrayMultiplication[i]);
        System.Console.Write(" ");
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

outputResultConsole(multiplicationNumberInArray(getRandomArray()));
