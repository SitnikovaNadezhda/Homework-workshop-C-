// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandomArray(int m, int n )
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i , j] = new Random().Next(1,50+1);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
     Console.WriteLine();
    }
    Console.WriteLine();
    
}

int[,] ArrayNew(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] NewArr = new int[array1.GetLength(0), array2.GetLength(1)];
    {
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                NewArr[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    }
    return NewArr;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arrayOne = CreateRandomArray(rows,columns);
int [,] sekondArr = CreateRandomArray(rows,columns);
int [,]  newArr=  ArrayNew(arrayOne,sekondArr);
ShowArray(arrayOne);
ShowArray(sekondArr);
Console.WriteLine("Произведение двух матриц:");
ShowArray(newArr);