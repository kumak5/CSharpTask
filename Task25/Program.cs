// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Решить задачу с использованием методов.
Console.WriteLine("Введите два числа: ");

int GetSum(int numberA, int numberB)
{
    int sum;
    int nBB = Math.Abs(numberB);
    sum = Convert.ToInt32(Math.Pow(numberA, nBB));
    return sum;
}

try
{
    int nA = int.Parse(Console.ReadLine());
    int nB = int.Parse(Console.ReadLine());
    int sum = GetSum(nA, nB);
    Console.WriteLine($"результат: {sum}");
}
catch (Exception ex)
{
    Console.WriteLine("Входное значение имеет не верный формат.");
    Console.WriteLine(ex.Message);
}





