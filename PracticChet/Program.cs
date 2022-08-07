// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();

Console.WriteLine("Программа проверки четности числа");

Console.WriteLine("Введите число");

string numberString = Console.ReadLine();

int number = int.Parse(numberString);

if(number%2 == 0) 
{
    Console.WriteLine("Введенное число четное");
}

else 
{
    Console.WriteLine("Введенное число нечетное");
}
