//Напишите функцию, которая принимает одно число 
// - высоту елочки и рисует ее консоли звездочками.
// 3 ->  *
//      ***
//     *****

void PrintTriangle(int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size * 2 - 1; j++)
        {
            // size - 1 потому что индексы начинаются с нуля
            if (j >= size - 1 - i && j <= size - 1 + i) Console.Write("*");
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("введите размер треугольника: ");
PrintTriangle(int.Parse(Console.ReadLine()!));