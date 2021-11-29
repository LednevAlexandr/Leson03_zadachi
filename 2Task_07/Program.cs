// Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты.

void RandomPrint(double[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i,j] = new Random().Next(min,max);
           Console.Write($"{arr[i,j],4}");
        }        
        Console.WriteLine();
    }
}
void square(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Pow(arr[i,j],2);
            Console.Write($"{arr[i,j],4}");
        }
        Console.WriteLine();
    }
}

double[,] array = new double[3,3];
RandomPrint(array,1,10); 
Console.WriteLine();
square(array);