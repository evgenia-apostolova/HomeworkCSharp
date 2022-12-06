/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] generateMatrix (int lengthRow, int lengthCol)
{
    int[,] matrix = new int[lengthRow,lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            matrix[i, j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void print2DArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    if (matrixB.GetLength(1) != matrixA.GetLength(0))
    {
        Console.WriteLine("Incompatible arrays in MatrixProduct");
    }
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); ++i)
    {
        for (int j = 0; j < matrixB.GetLength(1); ++j)
        {
            for (int k = 0; k < matrixA.GetLength(1); ++k)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.WriteLine("MatrixA:");
int[,] matrixA = generateMatrix(3,4);
print2DArray(matrixA);
Console.WriteLine("MatrixB:");
int[,] matrixB = generateMatrix(3,4);
print2DArray(matrixB);
Console.WriteLine("MatrixProduct:");
int[,] matrixProduct = MatrixProduct(matrixA, matrixB);
print2DArray(matrixProduct);
