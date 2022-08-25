// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Программа, принимающая введенные с клавиатуры М чисел и считающая сколько чисел больше 0 ввёл пользователь");

void InputArray(int[] array)
{
    int Lenght = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} числа через Enter: ");
        int element = int.Parse(Console.ReadLine()!);
        array[i] = element;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Введёны числа:");
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

int QuantityPozitivElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + 1;
        }
    }
    Console.WriteLine($"Пользователь ввел {result} элементов > 0");
    return result;
}


Console.WriteLine("Введите количество чисел: ");
string? length = Console.ReadLine();
int Length = int.Parse(length);

int[] array = new int[Length];
InputArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
QuantityPozitivElements(array);

