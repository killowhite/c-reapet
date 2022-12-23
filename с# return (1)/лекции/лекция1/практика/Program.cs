// приветствие пользователя

/* Console.WriteLine("Введите ваше имя");
String username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username); */

// сложить 2 числа

/* int numberA = 3;
int numberB = 5;
//Console.WriteLine(numberA+numberB);
int result = numberA + numberB;
Console.WriteLine(result); */

// частное двух чисел

/* double numberA = 10;
double numberB = 5;
Console.WriteLine(numberA/numberB) */

// частное двух случайных чисел

/* double numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
double numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
double result = numberA / numberB;
Console.WriteLine(result); */

/* на ввод имя если Михаил то вывод привет босс.
если другое, то просто привет*/

/* Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if(username.ToLower() == "Михаил")
{
    Console.WriteLine(" привет босс");
}
else
{
Console.WriteLine("привет, " + username);
} */

// перетаскивание гирь

/* int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;
if(a > max) max =a;
if(b > max) max =b;
if(c > max) max =c;
if(d > max) max =d;
if(e > max) max =e;

Console.Write("max = ");
Console.WriteLine(max); */

// цикл

Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("+");

int xa = 1;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 40;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("+");
Console.SetCursorPosition(xb,yb);
Console.Write("+");
Console.SetCursorPosition(xc,yc);
Console.Write("+");