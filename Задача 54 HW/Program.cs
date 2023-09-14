/* Задача 54: 
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 
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

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
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
void SortRows2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    int tmp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = tmp;
                   // Print2DArray(arr);
                    //Console.WriteLine($"{j}");
                }
            }
        }
    }
}
int rows = InputNum("Введи количество строк: ");
int columns = InputNum("Введи количество столбцов: ");
int minValue = InputNum("Введи минимальное значение массива: ");
int maxValue = InputNum("Введи максимальное значение массива: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
SortRows2D(myArray);
Print2DArray(myArray);