// методы, которые ничего не возвращают и не принимают
/*
void Metod1()
{
    Console.WriteLine("@");
}
Metod1(); //Вызов метода
*/
// Методы, которые ничего не возвращают, но принимают арг
/*
void Metod2(string msg)
{
    Console.WriteLine(msg);

}
Metod2(" текст сообщения "); //Вызов метода
*/
// Методы, которые возвращают, но не принимают
/*
int Metod3()
{
    return DateTime.Now.Year;
}
int  year = Metod3();
Console.WriteLine(year); //Вызов метода
*/
// Методы принимают и возвращают
/*
int Metod4(int count, string c)
{
    int i = 0;
    string result = "";
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Metod4(10, "text");
Console.WriteLine(res);
*/

// for
/*
string Metod4(int count, string  text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);
*/

// Цикл в цикле таблица умножения

 /* 
 for(int i = 0; i <= 10; i++)
{
 for(int j = 2; j <= 10; j++)
 {
    Console.WriteLine($"{i} * {j} = {i*j}");
 }
 Console.WriteLine();
}
*/

// Дан текст, нужно заменить (к) (К), ( ) (_), (С) (с)
/*
string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
            +" ежели бы вас послали вместо нашего милого Винценгероде, "
            +" вы бы взяли приступом согласие прусского короля. "
            +" Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0;i < length; i++)
    {
        if(text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}            
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С','с');
Console.WriteLine(newText);
*/

// Упорядочить массив от мин к макс

int[] array = {1,5,4,3,2,8,6,7};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;

    for(int j = i+1; j < array.Length; j++)
    {
      if(array[i] < array[minPosition]) minPosition = j;
    } 

    int temparary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temparary;

}
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);