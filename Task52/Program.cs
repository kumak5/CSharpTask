// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int n = 0;
int m = 0;

Console.Write("Введите количество строк (N): ");

bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);

if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата (N)");
}
else
{
    n = numberN;
}

Console.Write("Введите количество столбцов (M): ");

bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);

if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата (M)");
}
else
{
    m = numberM;
}

Console.WriteLine("");

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine(" ");
}

Console.WriteLine(" ");
Console.WriteLine("Средне арефмитическое каждого столбца: ");

double[] resultArray = new double[n];
for (int j = 0; j < m; j++)
{
    double result = 0;
    double result2 = 0;
    for (int i = 0; i < n; i++)
    {
        
        result = (result + array[i, j]);
        // Console.Write(result);
        // Console.Write(" ");
    }
result2 = result/n;
    Console.Write($"{result2}  ");
    // Console.WriteLine(" ");
}