// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33] 

Console.Clear();
Console.WriteLine("Программа, задающая массив из 8 элементов,и выводящая их на экран");

void inputArray(int[] array)
{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        int element = int.Parse(Console.ReadLine()!);
        array[i] = element;
    }
}

void printArray(int[] array)
{
    Console.WriteLine("Введён массив:");
    Console.WriteLine();

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

int[] array = new int[8];
inputArray(array);
Console.WriteLine();
printArray(array);