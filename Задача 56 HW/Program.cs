/* Задача 56:
 Задайте прямоугольный двумерный массив. 
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка 
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

int RowWithMinSumElement(int[,] arr)
{
    int minRow = 1;
    int tmpSum = 0;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tmpSum += arr[i, j];
        }
        if (i == 0) minSum = tmpSum;
        else if (minSum > tmpSum)
        {
            minSum = tmpSum;
            minRow = i + 1;
        }
        tmpSum=0;
    }
    return minRow;
}

int rows = InputNum("Введи количество строк: ");
int columns = InputNum("Введи количество столбцов: ");
int minValue = InputNum("Введи минимальное значение массива: ");
int maxValue = InputNum("Введи максимальное значение массива: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {RowWithMinSumElement(myArray)} строка.");