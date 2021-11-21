// 47. Написать программу копирования массива

void Random(int[] arr,int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
        Console.WriteLine(arr[i]);
    }
}

void coppy(int[] a, int[] b)
{
    for (int i = 0; i < a.Length; i++)
    {
        b[i] = a [i];
        Console.WriteLine(b[i]); 
    }
}

int[] array = new int[10];
int[] array1 = new int[10];
Random(array,-100,100);
Console.WriteLine();
coppy(array,array1);

