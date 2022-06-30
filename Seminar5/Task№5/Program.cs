// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void SwapArray1(int[] array)
{
    int[] arr = new int[array.Length];
    int left = array.Length-1;
    int rigth = array [0];
    for (int i = 0, j = array.Length; i< array.Length - 1; i++ , j++)
    {
       arr[j]= rigth * left;
       left-=1;
    }

    ShowArray(arr);
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArray(size);
ShowArray(arr);

Console.WriteLine();

SwapArray1(arr);