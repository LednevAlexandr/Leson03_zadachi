// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Random rnd = new Random();
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 4}");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] array)
{
     double summ = 0;
    double result;
    for (int i = 0; i < array.GetLength(1); i++)
   
    {
        for (int j = 0; j < array.GetLength(0); j++)
        
        {
            summ = summ + array[i,j];
        }
      result = summ/array.GetLength(0);
      Console.WriteLine($"среднее в столбце {i+1} = {result}");
      summ=0;
      result=0;
    }
    
}



int[,] arr = new int[3,3];
CreateArray(arr);
PrintArray(arr);
AverageColumn(arr);