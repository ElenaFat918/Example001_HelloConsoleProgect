// Программа принятия на вход 2 чисел и проверки кратности 2го числа 1му
Console.WriteLine ("Первое число");

string? NumberString1 = Console.ReadLine ();
int number1 = int.Parse (NumberString1!);

Console.WriteLine ("Второе число");

string? NumberString2 = Console.ReadLine ();
int number2 = int.Parse (NumberString2!);
int x = number2%number1;

if (x==0)
{
Console.WriteLine ("Число кратно");
}
else
{
Console.WriteLine ("Число не кратно, остаток " + x);
}