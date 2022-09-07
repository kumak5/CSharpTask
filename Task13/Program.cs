// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int trueNumber = int.Parse(number);
int lengthNamber = number.Length;
// number = number/10;
if (lengthNamber <3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    for (int i = lengthNamber; i > 3; i--)
    {
        trueNumber = trueNumber / 10;
    }
Console.WriteLine($"Третье число: {trueNumber % 10}");
}
