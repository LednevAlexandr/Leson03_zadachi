//  2. Даны два числа. Показать большее и меньшее число

double a;
double b;
Console.Write("Введите первое число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.Write("Введите второе число: ");
string r=Console.ReadLine();
b=Convert.ToInt32(r);

if(a<b)
{
    Console.WriteLine($"Меньшее число из двух {a}");
    Console.WriteLine($"большее число из двух {b}");
}
else
{
    Console.WriteLine($"Меньшее число из двух {b}");
    Console.WriteLine($"большее число из двух {a}");
}