//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
void listSqrt(int n)
{
int count = 1;

Console.Write(n + "-> ");

if (n > 0)
{

while (count <= n)
{
Console.Write(Math.Pow(count, 3) + ", ");
count++;
}
}
else
{
count = -1;
while (count >= n)
{
Console.Write(Math.Pow(count, 3) + ", ");
count--;
}
}
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

listSqrt(num);
