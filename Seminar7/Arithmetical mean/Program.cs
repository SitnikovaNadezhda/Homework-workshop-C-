// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void Show2DArray(int[,] array)
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
int[,] array = new int[5,5] {{15,39,98,46,35},{53,85,74,24,18},{16,96,11,54,87},{34,76,52,98,74},{87,43,65,87,67}};
 
            
 
            for (int i = 0; i < array.GetLength(1); i++) 
            {
                int sum = 0;
                
                for (int t = 0; t < array.GetLength(0); t++)
                {
                    sum += array[t, i];
                   
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)sum/array.GetLength(1)}");
                
            }

Show2DArray(array);
