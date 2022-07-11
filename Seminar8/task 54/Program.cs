// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i , j] = new Random().Next(min, max + 1);
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

int[,] SortArray(int[,]array)
{
    int buf;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int n = j + 1; n < array.GetLength(1); n++)
            {
                if(array[i,n]> array[i,j])
                {
                    buf = array[i,j];
                    array[i,j]= array[i,n];
                    array[i,n] = buf;
                }
            }
        }
    }
    return array;
}



Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(rows, columns, min, max);
int[,] ArrayNew = SortArray(myArray);
ShowArray(ArrayNew);


