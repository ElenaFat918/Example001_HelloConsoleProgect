// Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.WriteLine ("Введите число");
string? NumberString1 = Console.ReadLine();
int number1 = int.Parse (NumberString1!);

if (number1%7==0 && number1%23==0) 
{
Console.WriteLine ("Да");
}
else
{
Console.WriteLine ("нет");
}