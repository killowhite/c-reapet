// найти максимальное число из 9 чисел
/* int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 17;
int b1 = 23;
int c1 = 20;
int a2 = 27;
int b2 = 33;
int c2 = 30;
int a3 = 37;
int b3 = 43;
int c3 = 40;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
//int max =Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max); */


/* int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[]array = {11,21,31,40,43,45,75,70,85};


int max =Max(Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]), 
Max(array[6], array[7], array[8]));

Console.WriteLine(max); */

// есть массив , нужно найти элемент массива

/* int[] array ={1,5,6,8,4,2,6,7};

int n = array.Length;
int find = 7;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index =0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[]array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array,4);
Console.WriteLine(pos);
