// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");

int GetSumNumber(int numberA)
{
    int sum = 0;
    int nBB = Math.Abs(numberA);
    int digit;
    while (nBB > 0)
    {
        digit = nBB % 10;
        sum = sum + digit;
        nBB = nBB / 10;
    }
    return sum;
}

try
{
    int nA = int.Parse(Console.ReadLine());

    int sum = GetSumNumber(nA);
    Console.WriteLine($"результат: {sum}");
}
catch (Exception ex)
{
    Console.WriteLine("Входное значение имеет не верный формат.");
    Console.WriteLine(ex.Message);
}