// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//  452 -> 11

//  82 -> 10

//  9012 -> 12





int SumOfDigit(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int digit = 0;
        digit = number % 10;
        number = number / 10;
        
        sum += digit;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Программа, принимающая на вход число и выводящая сумму цифр в этом числе");

Console.WriteLine("Ведите число: ");
int number = int.Parse(Console.ReadLine()!);

var Sum = SumOfDigit(number);
Console.WriteLine(Sum);