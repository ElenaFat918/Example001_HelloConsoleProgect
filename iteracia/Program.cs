Console.WriteLine("Программа проверки ");

Console.WriteLine("Введите первое число");

string numberString = Console.ReadLine();

int numberA = int.Parse(numberString);

Console.WriteLine("Введите второе число");

string numberStringA = Console.ReadLine();

int numberB = int.Parse(numberStringA);

int sgrt = numberA * numberA;

if(numberA == sgrt)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("нет");
}