// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] CreateArray()
{
    int[] array = new int[8];
    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 2);

    return array;
}

var array = CreateArray();
// Console.Write("[");
// for (int i = 0; i < 7; i++)
//     Console.Write(array[i] + ",");
// Console.Write(array[8] + "]");



Console.Write("[");
int i = 0;
while (i < 7)
{
    Console.Write(" " + array[i]);
    i++;

    if (i <= 6)
    {
        Console.Write(",");
    }
}
Console.Write(" ]");



// Console.Write("[");
// for (int i = 0; i <= 8; i++)
// {
//     Console.Write(array[i]);
//     if (i != 8)
//         Console.Write(",");
// }
// Console.Write("]");
