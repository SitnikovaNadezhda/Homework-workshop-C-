//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{m},{n},{SumNumbers(m)}");
int SumNumbers(int m, int n)
{
    // if (m> n){
    
    // }
    if(m==n) return m;
    return (m + SumNumbers(m+1,n));
   
}
Console.WriteLine($"{m},{n},{SumNumbers(m,n)}");

