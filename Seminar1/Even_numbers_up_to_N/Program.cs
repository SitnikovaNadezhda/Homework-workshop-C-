Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
if (num % 2 == 1){
    num = num -1; 
}

while (num2 < num ){
   num2 = num2 + 2;
   Console.Write(num2 + " ");
}






