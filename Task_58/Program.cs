// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.



Console.WriteLine("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int cols1 = int.Parse(Console.ReadLine());

int[,] GetMatrix1(int row, int col)
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(10);

        }
    }
    return matrix1;
}

void PrintMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {

            Console.Write(matrix1[i, j] + " ");
        }
        Console.WriteLine();

    }
}

int[,] matrix1 = GetMatrix1(rows1, cols1);
Console.WriteLine("Массив: ");
PrintMatrix1(matrix1);


Console.WriteLine("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int cols2 = int.Parse(Console.ReadLine());

int[,] GetMatrix2(int row, int col)
{
    int[,] matrix2 = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(10);

        }
    }
    return matrix2;
}

void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {

            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();

    }
}

int[,] matrix2 = GetMatrix2(rows2, cols2);
Console.WriteLine("Массив: ");
PrintMatrix2(matrix2);

if (cols1 != rows2) Console.WriteLine("Умножение невозможно");

int[,] GeneretionMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[rows2,cols1];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            
            matrix[i, j] = 0;
            for (int z = 0; z < matrix2.GetLength(0); z++)
            {
                matrix[i, j] = matrix[i, j] + matrix1[i, z] * matrix2[z, j];
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }
}
Console.WriteLine("Произведение двух матриц: ");
int[,] newmatrix = GeneretionMatrix(matrix1, matrix2);
PrintMatrix(newmatrix);
