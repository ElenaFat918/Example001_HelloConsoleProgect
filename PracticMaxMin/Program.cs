// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее. 
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Программа вывода максимума и минимума");

Console.WriteLine("Введите первое число");

string numberString = Console.ReadLine();

int numberA = int.Parse(numberString);

Console.WriteLine("Введите второе число");

string numberStringA = Console.ReadLine();

int numberB = int.Parse(numberStringA);

if(numberA > numberB)

{
    Console.WriteLine("Максимальное число " + numberA);
}

else if(numberA < numberB)

{
Console.WriteLine("Максимальное число " + numberB);
}

else 
{
    Console.WriteLine("Введенные числа равны");
}
