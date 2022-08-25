// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Программа поиска точки пересечения двух прямых, заданных уравнениями");

Console.WriteLine("Введите значение b1: ");
string? Nb1 = Console.ReadLine();
double numberB1 = double.Parse(Nb1);

Console.WriteLine("Введите значение k1: ");
string? Nk1 = Console.ReadLine();
double numberK1 = double.Parse(Nk1);

Console.WriteLine("Введите значение b2: ");
string? Nb2 = Console.ReadLine();
double numberB2 = double.Parse(Nb2);

Console.WriteLine("Введите значение k2: ");
string? Nk2 = Console.ReadLine();
double numberK2 = double.Parse(Nk2);



void Coordinats(double numberB1, double numberB2, double numberK1, double numberK2)
{
double abscissa = (numberB2 - numberB1) / (numberK1 - numberK2);
double ordinate = numberK1 * abscissa + numberB1;
Console.WriteLine("(" + abscissa + ";" + ordinate + ")"); 
}

if (numberK1 / numberB1 == numberK2 / numberB2)
{
    Console.WriteLine("Прямые не могут пересекаться, т.к. они параллельны ");
}
else if(numberK1 - numberK2==0)
{
    Console.WriteLine("Значения не могут быть равны, т.к. прямые могут совпасть ");
}
else
{
 Coordinats(numberB1, numberB2, numberK1, numberK2);

Console.WriteLine();
}
