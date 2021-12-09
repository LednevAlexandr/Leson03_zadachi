// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


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

string SearchIndex(int[,] array)
{
     Console.Write("Введите число: ");
    int s = Convert.ToInt32(Console.ReadLine());
 string result = "Такого числа нету в масиве";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]==s)
            {
              result = ($"введенное число находитка в строке №{i+1} и в столбце № {j+1}");
            }
        }
    }
    return result;
}

int[,] arr = new int[10,10];
CreateArray(arr);
PrintArray(arr);
Console.WriteLine(SearchIndex(arr));