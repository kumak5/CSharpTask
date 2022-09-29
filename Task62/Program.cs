// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
var result = new int[n, n];

for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
{
    for (int j = padding; j < n - padding; j++)
        result[padding, j] = currentChar;
    for (int j = padding; j < n - padding; j++)
        result[n - padding - 1, j] = currentChar;
    for (int i = padding + 2; i < n - padding - 1; i++)
        result[i, padding] = currentChar;
    for (int i = padding + 1; i < n - padding - 1; i++)
        result[i, n - padding - 1] = currentChar;
    currentChar = 1 - currentChar;
    result[padding + 1, padding] = currentChar;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(result[i, j]);
    }
    Console.WriteLine();
}
if (n % 2 != 0 && result[0, 0] == 1)
    result[n / 2, n / 2] = 1;
