//  6. Выяснить является ли число чётным

int a;
Console.Write("Введите число");
string s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a%2==0)
{
  Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
} 