Console.Write("Введите количнство элементов масива: ");
int n = Convert.ToInt32(Console.ReadLine());

void Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
        Console.WriteLine(arr[i]);
    }
}

int[] arr = new int[n];

int Summa(int[] arr)
{
    int sum=0;
    for(int i=0;i<arr.Length;i++)
{
    if(arr[i]<0) sum = sum+arr[i];
}
return sum;
}

Random(arr,-100,100);
Console.WriteLine();
int result = Summa(arr);
Console.WriteLine(result);
