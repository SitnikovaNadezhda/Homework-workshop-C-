// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10 + 1);
        }
    }
    return array;
}
void ShowArray2(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[] SummaArray(int[,] array)
{
    int[] myNewArr = new int[array.GetLength(0)];
    int index = 0;
    int i = 0;
    {
        while (i < array.GetLength(0))
        {
            int j = 0; int sum = 0;
            while (j < array.GetLength(1))
            {
                sum += array[i, j];
                j++;
            }
            myNewArr[index] = sum;
            index++; i++;
        }
    }
    return myNewArr;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MinElrment(int[] array)
{
    int count = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        
        if (array[i] < min)
        {
            min = array[i];
            count = i;
        }
    }
    Console.WriteLine($"Строка № {count+1} имеет наименьшую сумму элементов:{min}");
}


Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArr = CreateRandomArray(rows, columns);
int[] summaArr = SummaArray(myArr);

ShowArray2(myArr);
ShowArray(summaArr);
MinElrment(summaArr);





