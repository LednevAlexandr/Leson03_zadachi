// Вводятся результаты контрольной работы 10 учащихся. Определите число не удовлетворительных, 
//удовлетворительных, хороших, отличных оценок. 
//Вывести среднюю оценку, полученную учащимися за контрольную работу.

void RandomArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           arr[i,j] = new Random().Next(1,6);
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

int[,] estimation = new int[2,10];

RandomArray(estimation);
PrintArray(estimation);