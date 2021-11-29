//  Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.

void PrintArray(int[,] arr, int min,int max)
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
void SummMulty(int[,] arr,out int summ, out int multy)
{
    summ=0;
    multy=1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j]%3==0 || arr[i,j]%5==0)
            {
                summ=summ+arr[i,j];
                multy=multy*arr[i,j];
            }
        }
    }
}

int[,] array = new int[3,3];

PrintArray(array,5,8);
Console.WriteLine();
int s,m;
SummMulty(array,out s, out m);
Console.Write($"{s},{m}");