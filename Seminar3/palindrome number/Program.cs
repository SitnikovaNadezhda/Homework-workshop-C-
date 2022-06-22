// Напишите программу, которая принимает на вход пятизначное число и проверяет, являеться ли оно палиндромом. 
int InvertedNumber(int num){
    int a = num % 10;
    int b = num / 10 % 10;
    int c = num / 100 % 10;
    int d = num / 1000 % 10;
    int e = num / 10000;
    int f = a * 10000 + b * 1000 + c * 100 + d * 10 + e;
    return f;
}
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondnum = InvertedNumber(number);
if (number > 99999 | number < 10000){
    Console.WriteLine("Число не пятизначное!");
}
else if (number == secondnum){
    Console.WriteLine("Число" + " "+ number+" " + "палиндром!");
}
else{
    Console.WriteLine("Число не является палиндромом!");
}



