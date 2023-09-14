/* Задача 55: 
Задайте двумерный массив.
 Напишите программу, которая заменяет строки на столбцы.
 В случае, если это невозможно, программа должна вывести сообщение для пользователя. */
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

int[,] ChangeRowsByColumns(int[,] arr)
{
    int[,] arr2 = Create2DArray(arr.GetLength(0), arr.GetLength(1));
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr2[j, i] = arr[i, j];
        }
    }
    return arr2;
}
bool CheckChange(int rows, int columns)
{
    return rows == columns;
}
int rows = InputNum("Введи кол-во строк: ");
int columns = InputNum("Введи кол-во столбцов: ");
if (CheckChange(rows, columns))
{
    int minValue = 1;
    int maxValue = 100;
    int[,] myArray = Create2DArray(rows, columns);
    Fill2DArray(myArray, minValue, maxValue);
    Print2DArray(myArray);
    Console.WriteLine();
    myArray = ChangeRowsByColumns(myArray);
    Print2DArray(myArray);
}
else Console.WriteLine("Невозможно заменить строки на столбцы");
