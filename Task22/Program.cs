// 22. Найти расстояние между точками в пространстве 2D/3D

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x1: ");
int x2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Abs(Math.Sqrt(Math.Pow((x2-x1),2)-Math.Pow((y2-y1),2)));

Console.Write(distance);