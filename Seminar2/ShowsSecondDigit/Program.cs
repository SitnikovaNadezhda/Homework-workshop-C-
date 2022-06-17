int SecondDigit(int num){
int number = num / 10 % 10;
  return number;
}
Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 | num > 999){
    Console.WriteLine("Введено некорректное число");
}
else{
int a = SecondDigit(num);
Console.WriteLine(a);
}




