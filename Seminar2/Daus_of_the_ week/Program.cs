void DausOfTheWeek(int num){
   if (num > 8){
    Console.WriteLine(" В неделе только 7 дней!");
  }
    if(num <= 5){
        Console.WriteLine("Будний день!");
    }
    if (num ==6) {
        Console.WriteLine("Выходной день!");
    }
    if (num==7) {
        Console.WriteLine("Выходной день!");
    }
}
Console.Write("Введите число: ");
DausOfTheWeek(Convert.ToInt32(Console.ReadLine()));






