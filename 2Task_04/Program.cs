// Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.

void SetArray(int[,] a){
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=new Random().Next(-100,100);
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

int Task01(int[,] a)
{
     int count = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i,j]>-9 && a[i,j]<0) count = count+1;
        }
    }
    return count;
}


Console.Write("Введите строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбцы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] a;
a=new int[n,m];

SetArray(a);
Print(a);
Console.Write(Task01(a));