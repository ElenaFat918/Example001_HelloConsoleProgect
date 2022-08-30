// Решение в группах задач:
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void Triangle(int A, int B, int C)
{
    if (((A + B) > C) && ((A + C) > B) && ((B + C) > A))
    {
        Console.WriteLine("Существует");
    }
    else
    {
        Console.WriteLine("Не существует");
    }
}

Console.WriteLine("Введите число A ");
string? NB1 = Console.ReadLine();
int number1 = int.Parse(NB1);

Console.WriteLine("Введите число B ");
string? NB2 = Console.ReadLine();
int number2 = int.Parse(NB2);

Console.WriteLine("Введите число C ");
string? NB3 = Console.ReadLine();
int number3 = int.Parse(NB3);

Triangle(number1, number2, number3);
