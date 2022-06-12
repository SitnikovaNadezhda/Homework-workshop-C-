
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

int min = numberB;

if (numberA < min) min = numberA;
   Console.Write("Меньшее число: ");
   Console.WriteLine(min);

if (numberB > max) max = numberB;
   Console.Write("Большее число: ");
   Console.WriteLine(max);

