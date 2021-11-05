//4. Найти максимальное из трех чисел

double a,b,c;
Console.WriteLine("Введите первое число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.WriteLine("Введите второе число: ");
string r=Console.ReadLine();
b=Convert.ToInt32(r);

Console.WriteLine("Введите третье число: ");
string y=Console.ReadLine();
c=Convert.ToInt32(y);

    double max=a;
    if (b>max) max=b;
    if (c>max) max=c;
    

 Console.WriteLine($"Максимальное число из трех: {max} ");
