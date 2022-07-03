// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
    Console.WriteLine();
}

int NumGreaterThan0 (int[] array)
{
    int count= 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]<0){
            count+=1;
        }
    }
    return count;
}

int[] myArr = CreateArray(7);
int amount = NumGreaterThan0(myArr);
ShowArray(myArr);
Console.WriteLine("The number of negative numbers in the array =" + amount );





