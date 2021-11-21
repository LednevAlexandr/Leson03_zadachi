// S13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите число: ");
int s = Convert.ToInt32(Console.ReadLine());

int n = 10;
if(s%n==0)
{
    Console.Write("число кратно заданному");
}
else
{
    Console.Write(s%n);
}