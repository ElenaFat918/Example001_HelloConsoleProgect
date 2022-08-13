// Задача 21: Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. 
// A (3,6); B (2,1) -> 5,09  
// A (7,-5); B (1,-1) -> 7,21 
 
Console.WriteLine("Введите x координату 1 точки:"); 
 
var xString1 = Console.ReadLine(); 
 
int x1 = int.Parse(xString1); 
 
Console.WriteLine("Введите y координату 1 точки:"); 
 
var yString1 = Console.ReadLine(); 
 
int y1 = int.Parse(yString1); 
 
Console.WriteLine("Введите x координату 2 точки:"); 
 
var xString2 = Console.ReadLine(); 
 
int x2 = int.Parse(xString2); 
 
Console.WriteLine("Введите y координату 2 точки:"); 
 
var yString2 = Console.ReadLine(); 
 
int y2 = int.Parse(yString2); 
 
double sqrt = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)*(y2 - y1)); 
 
Console.WriteLine("\n" + sqrt.ToString("N2"));