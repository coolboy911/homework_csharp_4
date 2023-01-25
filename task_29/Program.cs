// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

int[] StrToArray(string str)  // принимает запись исключительно вида "x, y, z, ..."
{
    // в этом блоке создадим пустой массив array
    int numCount = 1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ',') numCount ++;
    }
    int[] array = new int[numCount];

    // в этом блоке заполняем пустой массив числами
    numCount = 0;  // c его помощью будем ходить по индексам массива
    int commaPos = -2;  //чекпоинт так сказать (-2 для захвата первого числа / см. 23 строку)
    for (int i = 0; i < str.Length; i++)  // проходимся по строке индексно
    {
        if (str[i] == ',')
        {
            // этот блок создает строку между чекпоинтом и запятой
            string arrayCel = "";
            for (int j = commaPos + 2; j < i; j++) arrayCel += str[j];  // с чекпоинта + 2 до запятой не включительно
            array[numCount] = int.Parse(arrayCel);  //вписали значение в ячейку
            numCount++;  // перешли на следующий индекс созданного массива
            commaPos = i;  // переписали чекпоинт
        }
    }

    // последняя цифра так как в конце нет запятой  
    string lastArrayCel = "";
    for (int i = commaPos + 2; i < str.Length; i++) lastArrayCel += str[i];
    array[numCount] = int.Parse(lastArrayCel);  //вписали значение в ячейку

    return array;
}

string input = "1, 2, 5, 7, 19, 8, 13, 4";
Console.WriteLine(input);
int[] array = StrToArray(input);
Console.WriteLine(string.Join(" ", array));