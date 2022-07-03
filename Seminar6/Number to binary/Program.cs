// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int[] BinaryArr = new int[0];

while(num>0){
  int i= num%2;
  Array.Resize(ref BinaryArr, BinaryArr.Length + 1);
  BinaryArr[BinaryArr.Length - 1] = i;
  i++;
  num= num/2;
}
void SwapArray(int[] array)
{
    int buf = 0;

    for (int i = 0; i < array.Length / 2; i++)
    {
        buf = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = buf;
    }

    ShowArray(array);
}
void ShowArray( int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write( array[i]+" ");
    }
    Console.WriteLine();
}

SwapArray(BinaryArr);









