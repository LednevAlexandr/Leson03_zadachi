// Написать программу, которая обменивает элементы первой строки и последней строки

Random rnd = new Random();
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,20);
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

void Exchange(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)//строка
    {
        for (int j = 0; j < array.GetLength(1); j++)// столбец
        {
            temp = array[0,j];
            array[0,j] = array[array.GetLength(1)-1,j];
            array[array.GetLength(1)-1,j] = temp;
      Console.Write($"{array[i,j],4}");

        }
        Console.WriteLine();
    }
}

int[,] array = new int[3,3];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
Exchange(array);
