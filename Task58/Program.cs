// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int nLineArray = 2;
int mColumnArray = 2;

int[,] array1 = new int[nLineArray, mColumnArray];
int[,] array2 = new int[nLineArray, mColumnArray];
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

//генерация первого и второго массива
for (int i = 0; i < nLineArray; i++)
{
    for (int j = 0; j < mColumnArray; j++)
    {
        array1[i, j] = new Random().Next(1, 10);
    }
    for (int j = 0; j < mColumnArray; j++)
    {
        array2[i, j] = new Random().Next(1, 10);
    }
}

//ловим ошибку по несоответствии матриц, количество столбцов первого масива, 
//должно быть равно количеству строк второго массива
if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");

// умножение первого массива на второй
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            array3[i, j] += (array1[i, k] * array2[k, j]);

        }
    }
}

void Print(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");
    }
}


Console.WriteLine("Первый массив: ");
Print(array1);
Console.WriteLine("Второй массив: ");
Print(array2);
Console.WriteLine("Результат умножения первого на второй массив: ");
Print(array3);