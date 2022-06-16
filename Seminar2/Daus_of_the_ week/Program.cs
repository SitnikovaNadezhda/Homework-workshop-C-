void DausOfTheWeek(int a){
    if(a <= 5){
        Console.WriteLine("Будний день!");
    }
    else{
        Console.WriteLine("Выходной день!");
    }

}
Console.Write("Введите число: ");
int num =Convert.ToInt32(Console.ReadLine());
{
if (num > 7){
    Console.WriteLine(" В неделе только 7 дней!");
}
else{
    DausOfTheWeek(Convert.ToInt32(Console.ReadLine()));

}
}
