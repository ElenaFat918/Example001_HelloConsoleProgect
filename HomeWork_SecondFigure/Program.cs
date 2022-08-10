
//Программа принятия на вход трёхзначного числа и вывода второй цифры этого числа.


Console.WriteLine("Введите трёхзначное число");


string numberString = Console.ReadLine();


int number = int.Parse(numberString);

if(number > 99 && number < 999 && number > -999)

{
    int firstFigure = (number / 100) * 100; // Получаем cотню
    int secondFigure = (number -  firstFigure) / 10; // убираем сотню и десяток
    Console.WriteLine(secondFigure);
}
else Console.WriteLine("Введенное число не трёхзначное, пожалуйста введите трёхзначное число");