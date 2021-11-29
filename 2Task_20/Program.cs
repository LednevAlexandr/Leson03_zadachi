// Дан целочисленный двумерный массив, размерности n х m. Вывести на экран те элементы, у которых остаток от деления на m равен k. 

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