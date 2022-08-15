// Алгоритм сортировки методом максимального

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//вводим метод void для вывода массива на экран 
void PrintArray(int[] array)//в качестве аргумента приходит массив
{
    int count = array.Length;// получение количества элементов

    for (int i = 0; i < count; i++)// цикл от 0 до последнего
    {
        Console.Write($"{array[i]}");//вывод в одну строку
    }
Console.WriteLine();
}

PrintArray(arr);