// Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Программа определения расстояния между двумя точками в 3D пространстве");

Console.WriteLine("Введите x координату 1 точки:"); 
var xString1 = Console.ReadLine(); 
int x1 = int.Parse(xString1); 

Console.WriteLine("Введите y координату 1 точки:"); 
var yString1 = Console.ReadLine(); 
int y1 = int.Parse(yString1); 

Console.WriteLine("Введите z координату 1 точки:"); 
var zString1 = Console.ReadLine(); 
int z1 = int.Parse(zString1); 

Console.WriteLine("Введите x координату 2 точки:"); 
var xString2 = Console.ReadLine(); 
int x2 = int.Parse(xString2); 

Console.WriteLine("Введите y координату 2 точки:"); 
var yString2 = Console.ReadLine(); 
int y2 = int.Parse(yString2); 

Console.WriteLine("Введите z координату 2 точки:"); 
var zString2 = Console.ReadLine(); 
int z2 = int.Parse(zString2); 

double sqrt = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1) * (z2 - z1)); 
 
Console.WriteLine("\n" + sqrt.ToString("N2"));