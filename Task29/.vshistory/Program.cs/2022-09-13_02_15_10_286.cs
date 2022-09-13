// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. Элементы массива вводятся пользователем.

Console.WriteLine("Введите восемь чисел: ");

// int[] GetArray(int[] arrayD)
// {
//     // int[] arrayD = new int[7];
//     for (int i = 0; i < arrayD.Length; i++)
//     {
//         arrayD[i] = arrayD;
//     }
//     return arrayD;
// }

void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}

try
{

    int[] arrayDigits = new int[7];

    for (int i = 0; i < 8; i++)
    {
        arrayDigits[i] = int.Parse(Console.ReadLine());
    }

    PrintArrayToConsole(arrayDigits);
    // PrintArrayToConsole(array);
}
catch (Exception)
{

}


