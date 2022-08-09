// Написать прог, кот выводит случ число из отрезка х10б99ъ и показывает наибольш цифру числа

Random random = new Random();

int randomNumber = random.Next(10,99);

Console.WriteLine(randomNumber);

int firstDigit = randomNumber % 10;

int secondDigit = randomNumber / 10;
if (firstDigit > secondDigit)
    Console.WriteLine(firstDigit);
else 
    Console.WriteLine(secondDigit);