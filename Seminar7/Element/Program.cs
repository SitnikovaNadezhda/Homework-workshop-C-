// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
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
    
}


bool FindElement(int[,] array, int el)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            if (array[i,j]==el) return true;
        }
    }
    return false;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение элемента: ");
int element =Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandomArray(rows, columns, min, max);

ShowArray(myArray);
if(FindElement(myArray,element))
{
    Console.WriteLine("Элемент найден.");
}
else
{
    Console.WriteLine("Элемент не найден.");
}
