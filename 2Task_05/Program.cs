// Дан целочисленный двумерный массив, размерности n х m. Найти номера нечетных элементов, стоящих на четных местах. 

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

int[,] a;
a=new int[2,2];

void Printnummber(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i,j]%2!=0 && i%2==0 && j%2==0) Console.WriteLine($"{i,2},{j,2}={a[i,j],4}");
        }
    }
}

SetArray(a);
Print(a);
Printnummber(a);