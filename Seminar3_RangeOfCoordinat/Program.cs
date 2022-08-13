// Напишите программу, которая по заданному номеру четвверти,показывает диапазон возможных 
// координат точек в этой четверти (X, Y).
Console.Clear();


Console.WriteLine("Вычисление диапазона, в которой находится четверть");

Console.WriteLine("Введите номер четверти:");
var String = Console.ReadLine();
int result = int.Parse(String);
if (result < 1 || result >4)
{
    Console.WriteLine("Такой четверти нет.");
    return;
}
if (result == 0){
    Console.WriteLine("Невозможно вычислить диапазон для данной четверти");
    return;
}
else if (result == 1)  Console.WriteLine("x от 0 до ~, y от 0 до ~"); 
else if (result == 2)  Console.WriteLine("x от -~ до 0, y от 0 до ~"); 
else if (result == 3)  Console.WriteLine("x от -~ до 0, y от -~ до 0"); 
else if (result == 4)  Console.WriteLine("x от 0 до ~, y от -~ до 0");

//x > 0; y > 0 => 1
//x < 0; y > 0 => 2
//x < 0; y < 0 => 3
//x > 0; y < 0 => 4