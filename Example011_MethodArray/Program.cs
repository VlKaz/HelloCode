int[] array = { 1, 2, 3, 7, 5, 6, 7, 8 };

int find = 7;

int n = array.Length;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;

    }
    index++;
}