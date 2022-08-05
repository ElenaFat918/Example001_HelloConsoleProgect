Console.WriteLine("Программа вывода последней цифры числа");

Console.WriteLine("Введите число");

string numberString = Console.ReadLine();

int number = int.Parse(numberString);

int i = number %10;

Console.WriteLine("Последняя цифра введенного числа " + i);