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



int[,] SelectionSort(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int maxPozition = array[j, i];
            int temp = 0;
            if (array[j + 1, i] > maxPozition)
            {
                maxPozition = array[j + 1, i];
            }
            temp = array[j, i];
            array[j, i] = array[j + 1, i];
            array[j + 1, i] = temp;
        }
    }
    return array;
}

int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.Write("Измененный массив: ");
int[,] newarr = SelectionSort(array);
PrintArray(newarr);