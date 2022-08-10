    // Программа вывода третьей цифры заданного числа или сообщения об отсутствии третьей цифры в числе


Console.WriteLine("Введите число");


string numberString = Console.ReadLine();


int number = int.Parse(numberString);


if(number > 0 && number < 100)

Console.WriteLine("В этом числе отсутствует третья цифра");


else if(number > 99 && number < 1000)

{   int firstFigure = (number / 10) * 10; // Получаем cотню
    int secondFigure = number -  firstFigure; // убираем сотню и десяток
    Console.WriteLine(secondFigure);
}


else if(number > 999 && number < 10000)

{   int firstFigure = (number / 100) * 100; // Получаем 1000-ную
    int secondFigure = (number -  firstFigure)/10; // убираем сотню и десяток
    Console.WriteLine(secondFigure);
}


else if(number > 9999 && number < 100000)
{   int firstFigure = (number / 1000) * 1000; // Получаем 10000-ную
    int secondFigure = (number -  firstFigure)/100; // убираем сотню и десяток
    Console.WriteLine(secondFigure);
}


else if(number > 99999 && number < 1000000)
{   int firstFigure = (number / 10000) * 10000; // Получаем 10000-ную
    int secondFigure = (number -  firstFigure)/1000; // убираем сотню и десяток
    Console.WriteLine(secondFigure);
}
else
{
    Console.WriteLine("Введенное число не предусмотрено программой, пожалуйста обратитесь к разработчику");
}