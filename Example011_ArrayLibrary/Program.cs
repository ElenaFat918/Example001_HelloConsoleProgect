//Метод заполнения массива
void FillArray(int[] collection)// наименование методу фил, в качестве аргумента коллекшн
{
    int length = collection.Length;//получить длину массива
    int index = 0;//взять позицию индекс с 0
    while (index < length)//пока индекс ... будем делать
    {
        collection[index] = new Random().Next(1, 10);//обратиться к элементу коллекшн и положить
                                                    //туда новое случайное целое число из диапазона 1-10
             index++;//
    }

}

//Метод печати его элементов на экран
void PrintArray(int[] col)// VOID-метод ничего не возвращает(без return)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//Метод поиска элементов 
int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//если не встречается нужный элемент,искусственно возвращаем позицию в -1, что интерпретируется как элемент не найден

    while (index < count)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];//Создай новый массив, в котором будет 10 элементов.

FillArray(array);

array[4] = 4;//искусственно добавили 4ки в массив
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);