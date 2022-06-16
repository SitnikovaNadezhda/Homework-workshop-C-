Console.Write("Введите трех знычное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 && num > 999){
    Console.WriteLine("Введено некорректное число!");
}