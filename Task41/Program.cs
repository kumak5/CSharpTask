// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.Write("Введите число размера массива: ");


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

int[] getArray()
{
    int[] array = new int[sizeArray];
    Console.WriteLine("Введите число: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}

int countNumberInArray(int[] array)
{
    int countNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countNumber++;
        }
    }

    return countNumber;
}

void outputResultConsole(int countNumber)
{
    Console.Write($"Количество чисел больше нуля в массиве {sizeArray} чисел: {countNumber} ");

    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}


outputResultConsole(countNumberInArray(getArray()));