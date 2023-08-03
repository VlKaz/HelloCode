void FillArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    while (index < count)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int index = 0;

    while (index < count)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}

int FindPos(int[] col, int find)
{
    int count = col.Length;
    int index = 0;
    int pos = -1;

    while (index < count)
    {
        if (col[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}

int[] array = new int[10];


FillArray(array);
PrintArray(array);
Console.WriteLine("=====");
int i = FindPos(array, 5);
Console.WriteLine(i);
