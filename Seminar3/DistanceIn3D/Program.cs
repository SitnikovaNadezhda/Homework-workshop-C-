// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distAB(int x1, int y1,int z1, int x2, int y2, int z2)
{
return Math.Sqrt(Math.Pow(Math.Abs((x2 - x1)), 2) + Math.Pow(Math.Abs((y2 - y1)), 2) + Math.Pow(Math.Abs((z2 - z1)), 2));
}

Console.WriteLine("Введите координату Х1: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввудите координату Z1: ");
int cA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
int cB = Convert.ToInt32(Console.ReadLine());

double dis = Math.Round(distAB(xA, yA, cA, xB, yB, cB), 2);
Console.WriteLine("Длина отрезка: " + dis);
