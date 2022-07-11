// Задача 62: Заполните спирально массив 4 на 4.
// using System;
 
// namespace ConsoleApplication7
// {
//     class Program
//     {
//         static void Main()
//         {
//             const int n = 8;
//             var a = GetSpire(n);
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write(a[i,j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
 
//         private static int[,] GetSpire(int n)
//         {
//             var result = new int[n, n];
//             for (int currentChar = 1, padding = 0; padding < n/2; padding++)
//             {
//                 for (int j = padding; j < n - padding; j++)
//                     result[padding, j] = currentChar;
//                 for (int j = padding; j < n - padding; j++)
//                     result[n - padding - 1, j] = currentChar;
//                 for (int i = padding + 2; i < n - padding - 1; i++)
//                     result[i, padding] = currentChar;
//                 for (int i = padding + 1; i < n - padding - 1; i++)
//                     result[i, n - padding - 1] = currentChar;
//                 currentChar = 1 - currentChar;
//                 result[padding + 1, padding] = currentChar;
//             }
//             if (n%2 != 0 && result[0, 0] == 1)
//                 result[n/2, n/2] = 1;
//             return result;
//         }
//     }
// }
// Console.WriteLine("введите размер матрицы");



Console.WriteLine("Введите количество элементов в строке"); 
int n = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите количество элементов в cтолбце"); 
int m = int.Parse(Console.ReadLine()); 
int[,] mas = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n1 = n; 
int m1 = m; 
 
while (k <= n1 * m1) 
{ 
for (i = t; i < n; i++) 
mas[j, i] = k++; 
j = n - 1; 
for (i = t + 1; i < m; i++) 
mas[i, j] = k++; 
j = m - 1; 
for (i = n - 2; i >= t; i--) 
mas[j, i] = k++; 
j = t; 
for (i = m - 2; i > t; i--) 
mas[i, j] = k++; 
n--; 
m--; 
t++; 
j = t; 
} 
for (i = 0; i < mas.GetLength(0); i++) 
{ 
for (j = 0; j < mas.GetLength(1); j++) 
Console.Write("{0,2} ", mas[i, j]); 
Console.WriteLine(); 
} 
 
// Console.ReadKey();