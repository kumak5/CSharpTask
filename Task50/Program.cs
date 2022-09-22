// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int nLineArray = 0;
int mColumnArray = 0;
int kSearchLine = 0;
int lSearchColumn = 0;



nLineArray = new Random().Next(2, 9);
mColumnArray = new Random().Next(2, 9);

int[,] array = new int[nLineArray, mColumnArray];

for (int i = 0; i < nLineArray; i++)
{
    for (int j = 0; j < mColumnArray; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < nLineArray; i++)
{
    for (int j = 0; j < mColumnArray; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine(" ");
}

Console.WriteLine("Введите элемент массива: ");

bool parseKIsOk = int.TryParse(Console.ReadLine(), out int numberK);

if (!parseKIsOk)
{
    Console.WriteLine("Введено значение некорректного формата (K)");
}
else
{
    kSearchLine = numberK;
}

bool parseLIsOk = int.TryParse(Console.ReadLine(), out int numberL);

if (!parseLIsOk)
{
    Console.WriteLine("Введено значение некорректного формата (L)");
}
else
{
    lSearchColumn = numberL;
}

if (nLineArray < kSearchLine || mColumnArray < lSearchColumn)
{
    Console.WriteLine($"такого элемента [{kSearchLine},{lSearchColumn}] в массиве нет");
}
else
{
    Console.WriteLine($"элемент массива [{kSearchLine},{lSearchColumn}] = {array[kSearchLine, lSearchColumn]}");
}


