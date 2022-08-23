// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] createArray()
{
    var random = new Random();
    var result = new int[4];
    for (var i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 100);
    }
    return result;
}
void printArray(int[] array)
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

int SumElenementsNegativIndex(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + result);
    return result;
}

Console.Clear();
Console.WriteLine();

var arr = createArray();

Console.WriteLine("Сгенерировали массив:");
printArray(arr);

SumElenementsNegativIndex(arr);
Console.WriteLine();