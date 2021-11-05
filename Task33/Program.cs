//33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void Randomizer(int[] arr,int min,int max)
{
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]=new Random().Next(min,max);
        Console.WriteLine(arr[i]);
    }
}

int Summa(int[] array)
{
    int sum=0;
    int i=0;
  while (i<array.Length)
  {
      if (array[i]<0)
      {
          sum=sum+array[i];
      }
   i++;  
  }
  return sum;
}

int[] newArray = new int[12];
Randomizer(newArray,-10,10);
Console.WriteLine();
Console.WriteLine(Summa(newArray));