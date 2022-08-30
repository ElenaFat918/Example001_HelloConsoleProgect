//Решение в группах задач:
//Задача 44: Не используя рекурсию, выведите 
//первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
void Fibonacci (int n)
{
    int [] arr = new int [n];
    arr [0] = 0;
    arr [1] = 1;
    Console.Write ($"{arr[0]}, {arr[1]}, ");
    for (int i=2; i <n; i++)
    {
         arr [i] = arr[i-1]+ arr[i-2]; 
         Console.Write ($"{arr[i]}, "); 
    }
}
Fibonacci (20);

// решение фибоначи без массива.
// int A = 0;
// int B = 1;
// int C = 0;
// int i = 1;
// Console.WriteLine("Введите число ");
// int.TryParse(Console.ReadLine()!, out var n);
// Console.Write("0 ");
// while (i <= n-1)
// {
//     C=A+B;
//     A=B;
//     Console.Write(" " + B + " ");
//     B=C;
//     i++;
// }