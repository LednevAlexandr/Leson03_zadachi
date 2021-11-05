//1. По двум заданным числам проверять является ли первое квадратом второго

double a;
double b;
Console.Write("Введите первое число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.Write("Введите второе число: ");
string r=Console.ReadLine();
b=Convert.ToInt32(r);

if(a==Math.Pow(b,2))
{
    Console.WriteLine("a является квадратом b");
}
else
{
          Console.WriteLine("a не является квадратом b");
}