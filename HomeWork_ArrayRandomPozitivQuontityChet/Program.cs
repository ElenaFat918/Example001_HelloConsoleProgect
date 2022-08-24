// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] CreateArray()
{
    var random = new Random();
    var result = new int[10];
    for (var i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    return result;
}
void PrintArray(int[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

int QuantityEvenElenement(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    Console.WriteLine("количество чётных чисел в массиве = " + result);
    return result;
}

Console.Clear();
Console.WriteLine();

var arr = CreateArray();

Console.WriteLine("Сгенерировали массив:");
PrintArray(arr);

QuantityEvenElenement(arr);
Console.WriteLine();
