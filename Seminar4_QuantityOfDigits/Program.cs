// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Digits(int num)
{
    if (num == 0)
        return 1;

    var result = 0;
    
    while(num > 0)
    {
        num = num / 10;
        result++;
    }
    
    return result;
}


if (int.TryParse(Console.ReadLine()!, out var number))
{
    if (number <= 0)
        return;

    var result = Digits(number);

    Console.WriteLine(result);

} else {
    Console.WriteLine("Введено не число или слишком большое число!");
}