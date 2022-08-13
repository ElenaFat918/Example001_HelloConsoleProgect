//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.Clear();

Console.WriteLine("Таблица квадратов чисел от 1 до N");
Console.WriteLine("Введите N:");

int N = int.Parse(Console.ReadLine()!);

if(N<1)
{
    Console.WriteLine("Ошибка, N должно быть больше 0");
    return;
}
int i = 1;

while(N >= i)
{
     double A = Math.Pow(i, 2);
    Console.Write(A + " ");
    i++;
}