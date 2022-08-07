// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее. 
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Программа вывода максимума и минимума");

Console.WriteLine("Введите первое число");

string numberStringA = Console.ReadLine();

int numberA = int.Parse(numberStringA);

Console.WriteLine("Введите второе число");

string numberStringB = Console.ReadLine();

int numberB = int.Parse(numberStringB);

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
