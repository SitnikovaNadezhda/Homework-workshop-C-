//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] CreateRandomArrey( int size)
{
    int[] array = new int [size];
    for (int i =0; i < size ; i++){
        array[i]=new Random().Next(0,100);
    }
    return array;
}

int [] CreateArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++){
        Console.Write("Input" + i + "element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray( int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write( array[i]+" ");
    }
}
 int[] myRandomArray = CreateRandomArrey(8);
 ShowArray(myRandomArray);

int [] secondarray = CreateArray(8);
ShowArray(secondarray);

