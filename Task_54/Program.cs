// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// сортировка каждой строки по убыванию 
// создать одномерный массив и в нем сортировать

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);

        }
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

// int[,] SortSeal(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Array.Sort(array[i, j]);
//     }
// }

int[,] SelectionSort(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
            else
            {
                array[i, j] = array[i, j + 1];
            }
        }
    }
    return array;
}
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int maxPozition = array[0, 0];
//         int temp = 0;
//         if (array[i + 1, j] > maxPozition)
//         {
//             maxPozition = array[i + 1, j];
//         }
//         temp = array[i + 1, j];
//         array[i + 1, j] = array[i, j];
//         array[i, j] = temp;
//     }
// }
// return array;


int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.Write("Измененный массив: ");
int[,] newarr = SelectionSort(array);
PrintArray(newarr);