// 42. Определить сколько чисел больше 0 введено с клавиатуры

void Mas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    
    }
}

int[] arr = new int[5];

Mas(arr);

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0) sum = sum + 1;
}
Console.Write($"количество чисел больше 0 = {sum}");