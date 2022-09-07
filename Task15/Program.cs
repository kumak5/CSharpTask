// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine());
main(day);
void main(int day)
{
    if (day != 1 && day != 2 && day != 3 && day != 4 && day != 5 && day != 6 && day != 7)
    {
        Console.WriteLine("нужно ввести число от 1 до 7");
    }
    else if (day == 6 || day == 7)
    {
        Console.WriteLine("этот день выходной");
    }
    else
    {
        Console.WriteLine("этот день будний");
    }
}


