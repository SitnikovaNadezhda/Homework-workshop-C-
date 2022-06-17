int ThirdDigit(int num){
    int a = 0;
    a = num % 10;
  return a;
}


Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 | num > 999){
    Console.WriteLine("Введено некорректное число");
}
else{
int a = ThirdDigit(num);
Console.WriteLine(a);
}

