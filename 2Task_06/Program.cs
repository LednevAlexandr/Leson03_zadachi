// Дан целочисленный двумерный массив, размерности n х m. Найти максимум и минимум. Поменять их местами.
void RandomArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           arr[i,j] = new Random().Next(1,20);
       }
   }
}


void PrintArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           Console.Write($"{arr[i,j],4}");
       }
       Console.WriteLine();
   }
}

void FindMinMax(int[,] arr,out int min,out int max)
{
    max=arr[0,0];
    min=arr[0,0];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j]>max) max = arr[i,j]; 
            if(arr[i,j]<min) min = arr[i,j];
        }
    }
    Console.WriteLine($"{max}, {min}");
    Console.WriteLine();
    int temp = max;
    max = min;
    min = temp;
    Console.WriteLine($"{max}, {min}");
}

int[,] array;
array = new int[3,3];
RandomArray(array);
PrintArray(array);
int max,min;
FindMinMax(array,out max,out min);
PrintArray(array);