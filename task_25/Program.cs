//  Напишите функцию, которая принимает 
//  на вход два числа (A и B) и возводит 
//  число A в натуральную степень B.
int Degree(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}

Console.Write("Введите базовое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень числа: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(Degree(a, b));