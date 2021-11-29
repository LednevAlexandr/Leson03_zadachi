// Дан целочисленный двумерный массив, размерности n х m. Выяснить, какое число встречается в какой строке раньше 
//— положительное или отрицательное.
void SetArray(int[,] a, int min, int max)
{
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=new Random().Next(min,max);
        Console.Write($"{a[i,j],4}");
    }
    Console.WriteLine();
}
}

void MeetUp(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j]>0)
            {
              Console.Write($"в строке {i+1} первое число положительное и оно {arr[i,j]}");
              
            }
            else
            {
                if(arr[i,j]<0)
            {
                Console.Write($"В строке {i+1} следует раньше отрицательное число и это число {arr[i,j]}");
            }
               // неправильно работает метод
            }
        }
        Console.WriteLine();
        break;
    }
}

int[,] a;
a=new int[3,3];
SetArray(a,-100,100);
MeetUp(a);