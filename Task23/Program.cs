// 23. Показать таблицу квадратов чисел от 1 до N 
int i =1;
Console.Write("Введите N: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"кубы чисел от 1 до {a}");

while (i<=a)
{
     Console.Write(Math.Pow(i,2)+"  ");
     i++;
}

