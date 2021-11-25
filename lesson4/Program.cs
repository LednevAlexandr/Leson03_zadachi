// See https://aka.ms/new-console-template for more information
int[,] arr = new int[2,3];

void print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
            Console.WriteLine();

    }
}

void random(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10,100);
        }
    }
}

random(arr);
print(arr);

void image(int r, int m)
{
    if(arr[r,m] == 0)
    {
        arr[r,m] == 1;
        image(r-1,m);
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GerLength(1); j++)
        {
            
        }
    }
}

int fact(int n)
{
    if(n==1) return n=1;
    else return n*fact(n-1);
}