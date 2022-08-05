Console.WriteLine("Программа вывода последней цифры трехзначного числа");

Console.WriteLine("Введите число");

string numberString = Console.ReadLine();

int number = int.Parse(numberString);

int i = number - ((number / 10) * 10);

Console.WriteLine("Последняя цифра введенного числа " + i);