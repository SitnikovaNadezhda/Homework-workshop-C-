// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
int [] CreateRandomArrey( int size)
{
    int[] array = new int [size];
    for (int i =0; i < size ; i++){
        array[i]=new Random().Next(100,999);
    }
    return array;
}
void ShowArray( int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write( array[i]+" ");
    }
    Console.WriteLine();
}

int EvenNumbers ( int[] array)
{
    int buf=0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array [i]% 2 == 0)
        buf+=1;
    }
    return buf;
}



Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] myarr = CreateRandomArrey(size);
int num = EvenNumbers(myarr);
ShowArray(myarr);
Console.WriteLine($"Чётных чисел в массиве: {num}");










