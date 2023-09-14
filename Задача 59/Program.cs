/* Задача 59: 
Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] arr, int minV, int maxV)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minV, maxV + 1);
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
int[] MinIJ(int[,] arr)
{
    int minElem = arr[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minElem)
            {
                minElem = arr[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    int[] res = { minI, minJ };
    return res;
}

int[,] DelMinElemRowAndColumn(int[,] arr, int minI, int minJ)
{
    int[,] resArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int iRes = 0;
    int jRes = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != minI)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != minJ)
                {

                    resArr[iRes, jRes] = arr[i, j];
                    jRes++;
                }
            }
            jRes = 0;
            iRes++;
        }
    }
    return resArr;
}

int rows = InputNum("Введи кол-во строк: ");
int columns = InputNum("Введи кол-во столбцов: ");
int minV = 1;
int maxV = 10;
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minV, maxV);
Print2DArray(myArray);
Console.WriteLine();
int[] minIJ = MinIJ(myArray);
int[,] resArray = DelMinElemRowAndColumn(myArray, minIJ[0], minIJ[1]);
Print2DArray(resArray);