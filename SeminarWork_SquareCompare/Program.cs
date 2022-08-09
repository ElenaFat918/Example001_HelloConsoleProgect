// Программа принятия на вход 2х чисел и проверки, является ли одно число квадратом другого
Console.WriteLine("Первое число");
string? numberString1 = Console.ReadLine();
int number1 = int.Parse(numberString1);

Console.WriteLine("Второе число");
string? numberString2 = Console.ReadLine();
int number2 = int.Parse(numberString2);

int sqrt1 = number1 * number1;
int sqrt2 = number2 * number2;

if (sqrt2 == number1 || sqrt1 == number2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Нет");
}