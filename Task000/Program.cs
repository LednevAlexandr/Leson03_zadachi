// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void PrintArray(int[] array,int min, int max) 
{
     for (int i = 0; i < array.Length; i++)
     {
         array[i]=new Random().Next(min,max);
         Console.WriteLine(array[i]);

     }
}

int[] array = new int[100];
PrintArray(array,100,1000);

int summ=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2==0)  summ = summ+1;
}
Console.Write($"Сумма четных чисел = {summ}");