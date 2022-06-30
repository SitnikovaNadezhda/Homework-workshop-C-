// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArrey( int size)
{
    int[] array = new int [size];
    for (int i =0; i < size ; i++){
        array[i]=new Random().Next(0,100);
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
int SumofElements(int[] array)
{
   int sum =0;
   for(int i = 1; i < array.Length; i+=2){
    sum += array[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArrey(size);
int num = SumofElements(myArray);
ShowArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих под нечётными индексами: {num}");


