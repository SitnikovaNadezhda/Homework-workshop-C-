int SecondDigit(int num){
int number = num / 10 % 10;
  return number;
}
Console.WriteLine("Введите трех значное число ");
int num = Convert.ToInt32(Console.ReadLine());
int a = SecondDigit(num);
Console.WriteLine(a);





