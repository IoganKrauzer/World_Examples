Console.Clear();

void FillArray(int[] collec)
{
    int length = collec.Length;
    int index = 0;
    while (index < length)
    {
        collec[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrinArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collec, int find)
{
    int count = collec.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collec[index] == find)
        {
            position = index;
            break;
        }

        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrinArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);