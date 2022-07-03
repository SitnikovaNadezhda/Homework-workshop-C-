// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int[] myArr = new int[19];
myArr[0]=0;
myArr[1]=1;
int i = 2;
while(i < myArr.Length){
    myArr[i]= myArr[i-1]+myArr[i -2];
    i++;
}
void ShowArray( int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write( array[i]+" ");
    }
    Console.WriteLine();
}

ShowArray(myArr);
