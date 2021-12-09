// В матрице чисел найти сумму элементов главной диагонали

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

int SummDiagonal(int[,] array)
{
    int summ=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j) summ = summ+array[i,j];
        }
    }
    return summ;
}

int[,] arr = new int[5,10];
CreateArray(arr);
PrintArray(arr);
Console.WriteLine(SummDiagonal(arr));