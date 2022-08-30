// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
//чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }

    return result;
}
void ChetSqrtElements(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (var j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] *= array[i, j];
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine();
var array = CreateArrayWithRandomNumbers(m, n);
Console.WriteLine();
PrintArray(array);
ChetSqrtElements(array);
PrintArray(array);
