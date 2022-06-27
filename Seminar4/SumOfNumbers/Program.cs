//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfNumbers( int a){
    int numA = 0;
    int numB = a;
    int sum = 0;
   while(numB >0){
    numA = numB % 10;
    sum = sum + numA;
    numB = numB / 10;
   }
   return sum;
}


Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
int sunnum=SumOfNumbers(num);
Console.WriteLine(sunnum);

