// 41. Выяснить являются ли три числа сторонами треугольника 

Console.Write("Введите первую длину а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую длинну b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью длинну c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a+b>c & b+c>a & a+c>b) Console.WriteLine("является треуголником");
else
{
    Console.WriteLine("Не является треугольником");
}
