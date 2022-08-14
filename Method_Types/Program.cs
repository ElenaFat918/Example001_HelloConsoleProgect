// Вид 1
void Method1()
{
    Console.WriteLine("Автор Елена Анатольевна");
}
Method1();


//void Method2(string msg)
//{
   // ConsoleWriteLine(msg);
//}
//Method2(msg:"Текст сообщения"); //Именованные аргументы, когда методы принимают какое-то количество аргументов 

//void Method21(string msg, int count)
//{
   // int i = 0;
   // while(i < count)
   // {
    //    Console.WriteLine(msg);
    //    i++;
   // }
//}
//Method21(msg: "Текст", 4 count); //явно указываем именование аргумента и какое значение хотим ему присвоить
//Method21(count: 4, msg: "новый текст");

//Вид3

int Method3() //указываем тип данных, значение которого мы ожидаем, не принимает аргументы
{
    return DateTime.Now.Year;  //возврат текущей даты времени и года
}
int year = Method3(); // в левой части идентиф-р переменной которому присваиваем имя метода
//Console.WriteLine(year);


//Вид4
// string Method4(int count, string text)//аргумент возвращать строку C передавать count раз
// {
//     int i = 0;//возьмем цикл
//     string result = string.Empty;//переменная result , положим в нее (обязательное) значение например пустая строка (""), но чтобы все понимали код надо писать (string.Empty)

//     while(i < count)
//     {
//         result = result + text;
//         i++;//инкримент, --дискримент
//     }
//     return result;
// }
// string res = Method4(10, "z");//чтобы вызвать этот метод, создаем нужную переменную по порядку указать значение 10, текст для 10 раз
// Console.WriteLine(res);

string Method4(int count, string text)//аргумент возвращать строку C передавать count раз
{
    string result = string.Empty;//переменная result , положим в нее (обязательное) значение например пустая строка (""), но чтобы все понимали код надо писать (string.Empty)
    for(int i = 0; i < count; i++)//идет инициализация счетчика
       {
        result = result + text;
       }
    return result;
}
string res = Method4(10, "z");//чтобы вызвать этот метод, создаем нужную переменную по порядку указать значение 10, текст для 10 раз
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");//интерполяция строк
    }
    Console.WriteLine();
}