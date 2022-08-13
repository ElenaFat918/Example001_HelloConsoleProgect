// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Программа проверки пятизначного числа на полиндром");
Console.WriteLine("Введите пятизначное число:");
var String = Console.ReadLine();
int Number = int.Parse(String);

if (Number < 10000 && Number > 99999)//защита от дурака
{
    Console.WriteLine("Ошибка, введенное число непятизначное");
    return;
}

int Number1 = Number / 10000;
int Number2 = Number / 1000 - Number1 * 10;
int Number4 = (Number - (Number / 100 * 100)) / 10;
int Number5 = (Number - (Number / 10 * 10));

if(Number1 == Number5 && Number2 == Number4)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");