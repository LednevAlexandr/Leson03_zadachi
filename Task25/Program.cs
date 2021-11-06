// 25. Найти сумму чисел от 1 до А

Console.Write("Введите правый предел A: ");
int a = Convert.ToInt32(Console.ReadLine());

 int sum=0;
for (int i = 1; i <= a; i++)
{
    
     sum=sum+i; 
}
Console.Write($"сумма чисел из предела: {sum}");