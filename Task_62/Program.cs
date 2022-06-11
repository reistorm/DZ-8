// Заполните спирально массив 4 на 4



int[,] GetArray(int num)
{
    int n = 4;
    int[,] array = new int[n, n];
    num = 1;
    for (int j = 0; j < n; j++)
    {
        array[j, 0] = num;
        num++;
    }
    int num1 = array[n - 1, 0] + 1;
    for (int i = 1; i < n; i++)
    {
        array[3, i] = num1;
        num1++;
    }
    int num2 = array[3, n - 1] + 1;
    for (int j = 2; j >= 0; j--)
    {
        array[j, 3] = num2;
        num2++;
    }
    int num3 = array[n - 1, 3] + 1;
    for (int i = 2; i >= 0; i--)
    {
        array[0, i] = num3;
        num3++;
    }
    int num4 = array[0, num - 3] + 1;
    for (int i = 1; i < n - 1; i++)
    {
        array[1, i] = num4;
        num4++;
    }
    int num5 = array[1, n - 3] + 1;
    for (int j = 2; j > 0; j--)
    {
        array[j, 2] = num5;
        num5++;
    }
    for (int i = 0; i < n; i++)
    {
        for (int k = 0; k < n; k++)
        {
            Console.Write("{0}", array[i, k]);
        }
        Console.WriteLine();
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] newarray = GetArray(array);
PrintArray(newarray);