// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }

    return result;
}
void PrintArray(int[,] array) 
{
    for (var i = 0; i < array.GetLength(0); i++) 
    {
        for (var j = 0; j < array.GetLength(1); j++) 
        {
        }}}           
Dictionary<int,int> CountFrequency(int[,] array) 
{
    Dictionary<int,int> counters = new Dictionary<int, int>();

    foreach (int i in array)
        if (counters.ContainsKey(i))
            counters[i]++;
        else
            counters.Add(i, 1);

    return counters;
}

void PrintDictionary(Dictionary<int,int> dictionary) {
    foreach (var item in dictionary) {
        Console.WriteLine($"{item.Key} встречается {item.Value} раз");
    }
}

Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Всё плохо");
}

var array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);
var result = CountFrequency(array);
PrintDictionary(result);

