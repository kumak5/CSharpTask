// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндром.

Console.WriteLine("Введите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

FindPalidrom(number);

void FindPalidrom(int number)
{
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
    {
        Console.WriteLine("Это число является палиндром");
    }
    else
    {
        Console.WriteLine("Это простое число");
    }
}
