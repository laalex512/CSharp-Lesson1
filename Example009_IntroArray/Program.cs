void FillArray(int[] a)
{
    int length = a.Length;
    int index = 0;
    while (index < length)
    {
        a[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] a)
{
    int length = a.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("  " + a[index]);
        index++;
    }
}

int FindNumber(int[] a, int number)
{
    int length = a.Length;
    int index = 0;
    int result = -1;
    while (index < length)
    {
        if (a[index] == number)
        {
            result = index;
            break;
        }
        index++;
    }
    return result;
}

int FindMax(int[] a)
{
    int length = a.Length;
    int index = 1;
    int max=a[0];
    while (index < length)
    {
        if (a[index]>max) max=a[index];
        index++;
    }
    return max;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int findNumber = 5;
int findIndex = FindNumber(array, findNumber);
Console.WriteLine(" ");
Console.WriteLine(findNumber + " - это элемент с индексом " + findIndex);
int max= FindMax(array);
Console.WriteLine(" max = " + max);