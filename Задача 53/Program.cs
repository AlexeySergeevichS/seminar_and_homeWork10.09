/* Задача 53:
 Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива */
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
        {
            Console.Write($"{arr[i, j]}\t");
        }
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
void Change2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int tmp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = tmp;
    }
}

int rows = InputNum("Введи количество строк массива: ");
int columns = InputNum("Введи количество солбцов массива: ");
int minValue = InputNum("Введи минимальное значение массива: ");
int maxValue = InputNum("Введи максимальное значение массива: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
Change2DArray(myArray);
Print2DArray(myArray);