// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Random rnd = new Random();
void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(3,8);
        }
    }
}

void PrintArray(double[,] array)
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

void ReplaceElement(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i,j] = Math.Pow(array[i,j], 2);
            }
        }
    }
}
double[,] arr = new double[3,3];
CreateArray(arr);
PrintArray(arr);
ReplaceElement(arr);
Console.WriteLine();
PrintArray(arr);