// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Задайте число элементу 'n':");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число элементу 'm':");
int m = Convert.ToInt32(Console.ReadLine());

int ackermansAnswer = AckermanFunc(n, m);
Console.WriteLine($"Результат функции Аккермана: {ackermansAnswer}");
int AckermanFunc(int n, int m)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return AckermanFunc(n - 1, m);
    return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
}






