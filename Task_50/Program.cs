// В двумерном массиве n×k заменить четные элементы на противоположные

Random rnd = new Random();
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-100,100);
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

void Opposite(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]%2==0) 
            {
                array[i,j] = -array[i,j];
            }
        }
    }
}
int[,] arr = new int[3,3];
CreateArray(arr);
PrintArray(arr);
Opposite(arr);
Console.WriteLine();
PrintArray(arr);