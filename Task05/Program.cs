//5. Написать программу вычисления значения функции y=f(a)

int Function(int a)
{
    int y=a+10;
    return y;
}
int a;
Console.WriteLine("Введите значение a: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.WriteLine($"решение функции {Function(a)}");