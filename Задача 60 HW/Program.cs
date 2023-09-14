/* 
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int columns, int pages)
{
    return new int[rows, columns, pages];
}

void Fill3DArray(int[,,] arr, int[] rndArr)
{
    int r = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = rndArr[r];
                r++;
            }
        }
    }
}

void Print3DArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        Console.WriteLine($"Страница {k}");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k],3}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

int[] RandomArray(int startNum, int countNum)
{
    int[] arr = new int[countNum];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = startNum;
        startNum++;
    }
    Random rnd = new Random();
    for (int i = arr.Length - 1; i > 0; i--)
    {
        int tmp = arr[i];
        int rndIndex = rnd.Next(0, i + 1);
        arr[i] = arr[rndIndex];
        arr[rndIndex] = tmp;
    }
    return arr;

}

int rows = InputNum("Введи количество строк: ");
int columns = InputNum("Введи количество столбцов: ");
int pages = InputNum("Введи количество страниц: ");
if (rows * columns * pages <= 90)
{
    int[,,] myArray = Create3DArray(rows, columns, pages);
    int[] randomArray = RandomArray(10, 90);
    Fill3DArray(myArray, randomArray);
    Print3DArray(myArray);

}
else Console.WriteLine("Заданный массив невозможно заполнить двухзначными неповторяющимися числами!");