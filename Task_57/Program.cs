// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Random rnd = new Random();
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(10,100);
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

void DecreasArray(int[,] a)
{
    int tmp;
    
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int m=1; m<a.GetLength(1)-j; m++)
            {
                if (a[i,m]>a[i,m-1])
                {
                tmp=a[i,m]; 
                a[i,m]=a[i,m-1];
                a[i,m-1]=tmp;
                }
            }
        }   
    }
}
int[,] a = new int[5,5];
CreateArray(a);
 PrintArray(a);
System.Console.WriteLine();
 DecreasArray(a);
 PrintArray(a);