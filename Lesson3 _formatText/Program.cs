// ===== работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- ядумаю, -сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так краноречивы. Вы дадите мне чаю?";
            

// string s = "qwerty"
//             012345 
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for(int i = 0; i < Length; i++)//пробегаемся от 0 до конца строки
    {
       if(text[i] == oldValue) result = result +  $"{newValue}";//если текущий текс совпал с тем символом, который мы хотим заенить, то в результат мыдолжны будем положить новое значение строки newValue
       else result = result + $"{text[i]}";//если совпадений выше не обнаружено то в резалт добавим текщ символ, кот был
    }
    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
