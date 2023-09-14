/* Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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



void Fill2DArray(int[,] arr)
{
    int k = 0;
    int row = 0;
    int column = 0;
    int tmpCount = 0;
    int x = 0;
    while (k < arr.Length)
    {
        for (int i = column; i < arr.GetLength(1) - x; i++)
        {
            arr[row, i] = k;
            k++;
            tmpCount++;
        }
        column += tmpCount;
        tmpCount = 0;
        row++;
        column--;
        for (int i = row; i < arr.GetLength(0) - x; i++)
        {
            arr[i, column] = k;
            k++;
            tmpCount++;
        }
        row += tmpCount;
        tmpCount = 0;
        column--;
        row--;
        x--;
        Console.WriteLine($"{x}");
        for (int i = column; i > x; i--)
        {
            arr[row, i] = k;
            k++;
            tmpCount++;
        }
        column -= tmpCount;
        tmpCount = 0;
        column++;
        row--;
        x++;
        Console.WriteLine($"{x}");
        for (int i = row; i > x; i--)
        {
            arr[i, column] = k;
            k++;
            tmpCount++;
        }
        row -= tmpCount;
        tmpCount = 0;
        row++;
        column++;
        x++; 
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

int rows = InputNum("Введи количество строк: ");
int columns = InputNum("Введи количество столбцов: ");


int[,] myArray = Create2DArray(rows, columns);

Fill2DArray(myArray);

Print2DArray(myArray);
Console.WriteLine();
