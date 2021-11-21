// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int s = new Random().Next(10,100);
Console.Write(s);

int max;
if(s%10>s/10)
{  
    max = s%10;
}
else
{
    max=s/10;
}
Console.WriteLine();
Console.Write(max);