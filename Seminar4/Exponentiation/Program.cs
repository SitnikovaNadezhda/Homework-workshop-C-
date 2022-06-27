// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int power( int a, int b){
    int result = 1;
    for ( int i = 0; i < b; i++){
        result = result * a;
    }
    return result;
}


Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int newnum = power( a, b);
Console.WriteLine(newnum);







