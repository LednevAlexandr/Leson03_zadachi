// Показать двумерный массив размером m×n заполненный вещественными числами

Random rnd = new Random();
void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i,j] = rnd.Next(-100,100);
             
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

double[,] array = new double[10,10];

CreateArray(array);
PrintArray(array);