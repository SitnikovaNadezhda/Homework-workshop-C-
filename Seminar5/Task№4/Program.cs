// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int [] CreateRandomArrey( int size)
{
    int[] array = new int [size];
    for (int i =0; i < size ; i++){
        array[i]=new Random().Next(1,500);
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

int SelectedNumbers(int[] array )
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]>10){
          if (array[i]<99){
              count+=1;
          }
       }
    }
    return count;
}


int size = 123;
int[] myArray = CreateRandomArrey(size);
int num = SelectedNumbers(myArray);
ShowArray(myArray);
Console.WriteLine($"Количество элементов в массиве в заданном интервале от 10 до 99: {num}");


