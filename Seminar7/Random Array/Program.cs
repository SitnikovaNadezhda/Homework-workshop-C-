﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] array = new double[9, 4];
Random rand = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0;j< array.GetLength(1); j++){
    array[i,j] = 7 - rand.Next(12) + rand.NextDouble();
   }
}

void ShowArray(double[,] array)
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
ShowArray(array);

