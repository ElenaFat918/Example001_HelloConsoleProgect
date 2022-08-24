// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray(int length)
{
    var random = new Random();
    var result = new double[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 100);
    }
    return result;
}
void PrintArray(double[] array)
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

double DifferenceMaxMin(double[] array)
{
    double result = 0;
    double max = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
           
        }
        else if(array[i] < min)
        {
            min = array[i];
           
        }
    }
     Console.WriteLine(max); 
     Console.WriteLine(min);
    result = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами в массиве = " + result);
    return result;
}

Console.Clear();
Console.WriteLine();

double []arr = CreateArray(5);

Console.WriteLine("Сгенерировали массив:");
PrintArray(arr);

DifferenceMaxMin(arr);
Console.WriteLine();