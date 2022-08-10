//Программа принятия на вход трёхзначного числа и вывода второй цифры этого числа

Console.WriteLine("Введите трёхзначное число");

string numberString = Console.ReadLine();

int number = int.Parse(numberString);

int firstFigure = (number / 100) * 100; // Получаем cотню

int secondFigure = (number -  firstFigure) / 10; // убираем сотню и десяток

Console.WriteLine(secondFigure);