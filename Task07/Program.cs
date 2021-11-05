//  7. Показать числа от -N до N

Console.WriteLine("Введите -N: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число положительное N: ");
int b = Convert.ToInt32(Console.ReadLine());

int i=a;
  while (i>=b)
  {
       Console.WriteLine(a);
       i++;
  }
