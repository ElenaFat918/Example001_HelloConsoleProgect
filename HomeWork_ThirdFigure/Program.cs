    // Программа вывода третьей цифры заданного числа или сообщения об отсутствии третьей цифры в числе


Console.WriteLine("Введите число");


string numberString = Console.ReadLine();


int number = int.Parse(numberString);

while(number >= 1000)
{
    number = number/10;
}

if(number > 0 && number < 100)

Console.WriteLine("В этом числе отсутствует третья цифра");


else if(number > 99 && number < 1000)

{   int firstFigure = (number / 10) * 10; // Получаем cотню
    int secondFigure = number -  firstFigure; // убираем сотню и десяток
    Console.WriteLine(secondFigure);
}
