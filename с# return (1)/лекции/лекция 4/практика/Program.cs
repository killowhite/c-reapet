string[,]table = new string[2,3];
//string.Empty инициализация
//table[0,0]  table[0,1]... table[0,4]
//table[1,0]  table[1,1]... table[1,4]
/*
table[1,2] = "слово";// вызов элемента
for (int rows = 0; rows < 2; rows++) //строки
{
    for(int colums = 0; colums < 5; colums++) // столбцы
    {
      Console.WriteLine($"{table[rows,colums]}-");
    }
}
*/
/*
int[,] matrix = new int[3,4];
void PrintArray(int[,] matr)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
*/

//создать двумерный масив и закрасить изображение

/*

int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,1,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0},
    {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};
void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    }
}
void FillImage(int row, int col)
{
    if(pic[row,col] == 0)
    {
        pic[row,col] =1;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row +1,col);
        FillImage(row,col+1);
    }
}
PrintImage(pic);
Console.WriteLine();
FillImage(13, 13);
PrintImage(pic);
*/

//найти 5!
/*
int Factorial (int n)
{
    if( n ==1) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(5));
*/

// f(1) = 1 ; f(2) = 1; f(n) = f(n-1)+f(n-2)

int Fibanacci(int n)
{
    if(n ==1 || n == 2) return 1;
    else return Fibanacci(n-1) + Fibanacci(n-2);
}

for(int i =1; i < 10; i++)
{
    Console.WriteLine(Fibanacci(i));
}