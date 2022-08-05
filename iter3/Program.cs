Console.WriteLine("Программа вывода всех целых чисел от -N до N");

Console.WriteLine("Введите число");

string numberString = Console.ReadLine();

int number = int.Parse(numberString);

if(number < 0)

number = number * (-1);

int i = number * (-1);

while (i <= number)

Console.WriteLine(i++);