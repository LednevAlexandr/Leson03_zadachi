// 31. Задать массив из 8 элементов и вывести их на экран 

void Randoms(int[] arr, int min,int max)
{
    for(int i=0; i < arr.Length;i++)
    {
        arr[i] = new Random().Next(min,max);
        Console.WriteLine(arr[i]);
    }
}


int[] array = new int[8];

Randoms(array,-100,100);