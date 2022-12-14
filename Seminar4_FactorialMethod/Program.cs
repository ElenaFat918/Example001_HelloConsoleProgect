// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// long Factorial (long num)
// {
//     var result = 1L;  
//     for(long i = 1; i <= num; i ++)
//     {
//         result *= i;
//     }
    
//     return result;
// }

// Console.WriteLine("Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N");
// Console.WriteLine("Введите ваше число: ");
// if (long.TryParse(Console.ReadLine()!, out var number))
// {
//     if (number < 0)
//         return;
//     var result = Factorial(number);

//     Console.WriteLine(result);

// } 
// else {
//     Console.WriteLine("Введено не число или слишком большое число!");
// }
// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

long Factorial(long num)
{
    var result = 1L;
    for (long i = 1; i <= num; i++)
    {
        result *= i;
    }

    return result;
}


Console.WriteLine("Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N");

for (; ; )
{
    Console.WriteLine("Введите ваше число: ");
    Console.WriteLine("Для выхода введите Y");

    var inputString = Console.ReadLine()!;

    if (inputString.Equals("Y"))
        break;

    if (long.TryParse(inputString, out var number))
    {
        if (number < 0) {
            Console.WriteLine("Число должно быть неотрицательным");
            continue;
        }
        var result = Factorial(number);

        Console.WriteLine(result);

    }
    else
    {
        Console.WriteLine("Введено не число или слишком большое число!");
    }
}