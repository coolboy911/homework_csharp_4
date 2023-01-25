// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
int SumOfDigits(int number)
{
    int total = 0;
    while (number > 0)
    {
        total += number % 10;
        number /= 10;
    }
    return total;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumOfDigits(a));