// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// нах сумму и выводим строку где меньшее сумма элементов

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

void FindMinSumElements(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = sum + array[j, i];

    }
    Console.WriteLine($"Сумма {j+1} строки = " + sum);
    }
    
    return;
}
int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
FindMinSumElements(array);