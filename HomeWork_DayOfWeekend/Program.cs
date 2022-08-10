
//Программа принятия на вход цифры, обозначающей день недели и проверки соответствия выходному дню


Console.WriteLine("Программа проверки соответствия цифре выходному дню");


Console.WriteLine("Введите номер дня недели");


string numberString = Console.ReadLine();


int number = int.Parse(numberString);


if (number > 0 && number < 6)
{
    Console.WriteLine("нет");
}

else if(number > 5 && number < 8)
{
   Console.WriteLine("да");
}

else 
{
    Console.WriteLine("Такого дня недели нет, введите пожалуйста число от 1 до 7 включительно");
}    