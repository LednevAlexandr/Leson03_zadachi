//  Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов.

void SetArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]=new Random().Next(5,10);
        }
    }
}

void Print(int[,] a)
{
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($"{a[i,j],4}");
    }
    Console.WriteLine();
}
}

int[,] a;
a = new int[5,5];

void Task02(int[,] a, out int summ,out int multy)
{
    summ=0;
    multy=1;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i,j]%2==0) 
            {
                summ=summ+a[i,j];
                multy=multy*a[i,j];
            }
        }
    }
}

SetArray(a);
int q,w;
Task02(a,out q, out w);
Console.WriteLine($"{q},{w}");