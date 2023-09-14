/* 
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int tmpSum = 0;
            for (int r = 0; r < matrixA.GetLength(1); r++)
            {
                tmpSum += matrixA[i, r] * matrixB[r, j];
            }
            resMatrix[i, j] = tmpSum;
            tmpSum = 0;
        }
    }
    return resMatrix;
}

int rowsMatrixA = InputNum("Введи количество строк матрицы A: ");
int columnsMatrixA = InputNum("Введи количество столбцов матрицы A = количеству строк матрицы B: ");
int rowsMatrixB = columnsMatrixA; //InputNum("Введи количество строк матрицы B: ");
int columnsMatrixB = InputNum("Введи количество столбцов матрицы B: ");
if (columnsMatrixA == rowsMatrixB)
{
    int minValue = 1; //InputNum("Введи минимальное значение массива: ");
    int maxValue = 10; //InputNum("Введи максимальное значение массива: ");
    int[,] matrixA = Create2DArray(rowsMatrixA, columnsMatrixA);
    int[,] matrixB = Create2DArray(rowsMatrixB, columnsMatrixB);
    Fill2DArray(matrixA, minValue, maxValue);
    Fill2DArray(matrixB, minValue, maxValue);
    Console.WriteLine("Матрица A:");
    Print2DArray(matrixA);
    Console.WriteLine("Матрица B:");
    Print2DArray(matrixB);
    Console.WriteLine("Матрица C=A*B:");
    Print2DArray(MatrixMultiplication(matrixA, matrixB));
}
else Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы!!!");