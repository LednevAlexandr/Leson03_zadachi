// 34. Написать программу замену элементов массива на противоположные

void RandomArray(int[] array,int min,int max)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(min,max);
    Console.Write(array[i]+" ");
    }

}

int[] newArray = new int[10];
RandomArray(newArray,-10,10);
Console.WriteLine();

for(int i=0;i<newArray.Length;i++)
{
         newArray[i]=-newArray[i];
         Console.Write(newArray[i]+" ");
 }

