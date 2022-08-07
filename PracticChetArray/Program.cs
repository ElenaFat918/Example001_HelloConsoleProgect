// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Программа вывода четных чисел от 1 до N");

Console.WriteLine("Введите число");

string numberString = Console.ReadLine();

int N = int.Parse(numberString);

Console.WriteLine("Вывожу четные числа:");

int i = N;

while(i > 1)
{
   if(i%2 == 0)
      {
      Console.WriteLine(i--);
      }
i --;
}