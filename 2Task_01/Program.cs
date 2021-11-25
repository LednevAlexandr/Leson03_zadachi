// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.


void SetArray(int[,] a){
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=new Random().Next(10,100);
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

void Task01(int[,] a,out int summ, out int multi)
{
     summ=0;
     multi=1;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            summ=a[i,j]+summ;
            multi=a[i,j]*multi;
        }
    }
}


Console.Write("Введите строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбцы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] a;
a=new int[n,m];

SetArray(a);
Print(a);
Console.WriteLine();
int su,am;
Task01(a,out su,out am);
Console.WriteLine($"{su} {am}");