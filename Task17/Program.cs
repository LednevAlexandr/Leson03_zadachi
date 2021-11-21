// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число: ");
double s = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());

double c = Math.Pow(s,2);
double b = Math.Pow(a,2);

if(s==b) Console.Write("перое квадрат второго");
if(a==c) Console.Write("перое квадрат второго");