// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16 

Console.Clear();
Console.WriteLine("Программа, принимающая на вход два числа (A и B) и возводящая число A в натуральную степень B");

double Pow (double number, double degree) 
{
    double result = Math.Pow(number, degree);
    return result;
}

Console.WriteLine("Ведите число A");
double number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите число B");
double degree = int.Parse(Console.ReadLine()!);


var result =  Pow(number, degree);
Console.WriteLine(result);