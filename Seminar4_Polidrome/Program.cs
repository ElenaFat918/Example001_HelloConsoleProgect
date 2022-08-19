bool CheckPalindrome(int number)
{
    int digit1 = number / 10000;
    int digit5 = number % 10;

    if (digit1 != digit5)
        return false;

    int digit2 = number / 1000 % 10;
    int digit4 = number % 100 / 10;

    if (digit2 != digit4)
        return false;

    return true;
}

int Pow2(int number)
{
    return number * number;
}

void WriteHelloWorld()
{
    Console.WriteLine("Hello, world!");
}

// WriteHelloWorld();

// Pow2(5);


// WriteHelloWorld();

Console.WriteLine("Введите 5-значное число для проверки");
var numberString = Console.ReadLine();
var number = int.Parse(numberString!);

if (number < 10_000 && number >= 100_000)
{
    return;
}

var result = CheckPalindrome(number);

if (result == true)
    System.Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Не является");