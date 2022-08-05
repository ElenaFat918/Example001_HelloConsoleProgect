Console.WriteLine("Программа проверки является ли первое число квадратом второго");

Console.WriteLine("Введите первое число");

string numberString = Console.ReadLine();

int numberA = int.Parse(numberString);

Console.WriteLine("Введите второе число");

string numberStringA = Console.ReadLine();

int numberB = int.Parse(numberStringA);

int sgrt = numberA * numberA;

if(numberB == sgrt)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("нет");
}