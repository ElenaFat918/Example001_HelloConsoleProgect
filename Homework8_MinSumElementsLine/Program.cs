// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:1 строка

Console.Clear();
Console.WriteLine($"Программа, упорядочивающая по убыванию элементы каждой строки двумерного массива");
Console.WriteLine($"\nЗадайте двумерный массив, для этого введите размер массива m x n и верхнюю границу создаваемого случайного числа:");
int m = InputNumbers("Введите размер строк m: ");
int n = InputNumbers("Введите размер стлдбцов n: ");
int maxValue = InputNumbers("Введите верхнюю границу создаваемого случайного числа: ");

int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

int minSumElementsLine = 0;
int result = SumElementsLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempresult = SumElementsLine(array, i);
    if (result > tempresult)
    {
        result = tempresult;
        minSumElementsLine = i;
    }
}

Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minSumElementsLine + 1}  Сумма элементов в ней: {result}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(maxValue);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumElementsLine(int[,] array, int i)
{
    int result = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
    return result;
}