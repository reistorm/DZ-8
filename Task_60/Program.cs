// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы 
// каждого элемента.


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int appliq = int.Parse(Console.ReadLine());

int[,,] Create3DMatrix(int rows, int cols, int appliq)
{
    int[,,] matrix = new int[rows, cols, appliq];
    Random rnd = new Random(Guid.NewGuid().GetHashCode());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = rnd.Next(10, 100);
            
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write(matrix[i, j, z] + " ");
            }
        }
        Console.WriteLine();

    }
}

int[,,] newmatrix = Create3DMatrix(rows, cols, appliq);
PrintMatrix(newmatrix);
