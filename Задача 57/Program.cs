/* Задача 57:
 Составить частотный словарь элементов двумерного массива. 
 Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных. */
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
int[] CreateArray(int size)
{
    return new int[size];
}
void Sort1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
    }
}
void Fill1DArrayFrom2DArray(int[,] arr2D, int[] arr1D)
{
    int k = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr1D[k] = arr2D[i, j];
            k++;
        }
    }
}
void VocabFrequency(int[] arr)
{
    Sort1DArray(arr);
    int tmp = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == tmp)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{tmp} встречается {count} раз");
            tmp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp} встречается {count} раз");
}
int rows = InputNum("Введи кол-во строк: ");
int columns = InputNum("Введи кол-во столбцов: ");
int minV = 1;
int maxV = 10;
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minV, maxV);
Print2DArray(myArray);
int[] newMyArray = CreateArray(myArray.Length);
Fill1DArrayFrom2DArray(myArray, newMyArray);
VocabFrequency(newMyArray);
