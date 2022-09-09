//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintRecNaturNumbers(int m, int n)

{
    if (m == n) Console.Write($"{n} ");
    else if (m < n)
    {
        Console.Write($"{m} ");
        PrintRecNaturNumbers(m + 1, n);
    }

    else
    {
        Console.Write($"{m} ");
        PrintRecNaturNumbers(m - 1, n);
    }

}

int m = 6;
int n = 3;
PrintRecNaturNumbers(m, n);