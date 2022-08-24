// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125



Console.Clear();

Console.WriteLine("Таблица кубов чисел от 1 до N");
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
     double A = Math.Pow(i, 3);
    Console.Write(A + " ");
    i++;
}