// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
// чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.WriteLine("Программа вывода максимального числа");

Console.WriteLine("Введите первое число");

string numberString = Console.ReadLine();

int numberA = int.Parse(numberString);

Console.WriteLine("Введите второе число");

string numberStringB = Console.ReadLine();

int numberB = int.Parse(numberStringB);

Console.WriteLine("Введите третье число");

string numberStringC = Console.ReadLine();

int numberC = int.Parse(numberStringC);

int max = 0;

if (numberA >= numberB && numberA >= numberC)
 {
    max = numberA;
 }
          
if(numberA >= numberB && numberA >= numberC)

{
    max = numberA;
}
    
    else if(numberB >= numberA && numberB >= numberC)
    {
        max = numberB;
    }

    else if(numberC >= numberA && numberC >= numberB)
    {
        max = numberC;
    }
Console.WriteLine("Максимальное число " + max);