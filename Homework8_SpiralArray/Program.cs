// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine($"Программа создающая массив 4 на 4 с заполнением элементами спирально");
int n = InputNumbers("Введите число строк(столбцов) будущего массива: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] SpiralArray = new int[n, n];

int temporary = 1;
int i = 0;
int j = 0;

while (temporary <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
{
 SpiralArray[i, j] = temporary;
  temporary++;
  if (i <= j + 1 && i + j < SpiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(SpiralArray);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      // if (array[i,j] / 10 <= 0)
      // Console.Write($" {array[i,j]} ");

      // else 
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}