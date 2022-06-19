int ThirdDigit(int num){
    int a = 0;
    if (num > 999){
      num = num /=10;
      a = num % 10;
    }
    else {
      a = num % 10;
    }
  return a;
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 ){
    Console.WriteLine("В этом числе нет третей цифры.");
}

else{
int a = ThirdDigit(num);
Console.WriteLine(a);

}
