// Дан целочисленный двумерный массив, размерности n х m. Найти среднее арифметическое всех элементов массива.

Random rnd = new Random();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-100,100);
            Console.Write($"{array[i,j],5}");
        }
        Console.WriteLine();
    }
}
  int summ=0;
int ArithmeticMean(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i,j];
        }
    }
   return  summ/array.Length;
}

int[,] array = new int[2,2];

PrintArray(array);
int s = ArithmeticMean(array);
Console.WriteLine(s);