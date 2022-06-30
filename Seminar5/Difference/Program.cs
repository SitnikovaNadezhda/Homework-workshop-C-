// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] CreateRandomArrey( int size)
{
    int[] array = new int [size];
    for (int i =0; i < size ; i++){
        array[i]=new Random().Next(1,100);
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
int MaxNum(int[] array)
{
    int max = array[0];
    
    for(int i = 0; i < array.Length; i++){
        if (array[i]>max)
         max = array[i];
    }
    return max;
}
int MinNum(int[] array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++ )
    {
     if (array[i]< min)
        min = array[i];
    }
    return min;
}
int Difference(int a, int b)
{
    int diff = a - b;
    return diff;
}
Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] myarray=CreateRandomArrey(size);
int num1 = MaxNum(myarray);
int num2 = MinNum(myarray);
int num3 = Difference(num1, num2);
ShowArray(myarray);
Console.WriteLine($"Разница:{num3}, max number {num1} ,min number {num2}");







