// Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.

// !!!откуда брать массив, возьмем его из 34 задания!!!


Console.WriteLine("Введите размер массива: ");


int siseArray = 0;


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
        array[i] = random.Next(-1000, 1000);
    }
    return array;
}

int sumNumberInArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {

        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }

    }
    return sum;
}

void outputResultConsole(int sum)
{
    Console.Write($"Сумма в масиве из {siseArray} чисел: {sum} ");
    // for (int i = 0; i < siseArray; i++)
    // {
    //     System.Console.Write(array[i]);
    //     System.Console.Write(" ");
    // }
}

outputResultConsole(sumNumberInArray(getRandomArray()));