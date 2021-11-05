// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координаты x: ");
int x =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y: ");
int y =Convert.ToInt32(Console.ReadLine());

if (x>0 & y>0) Console.WriteLine("2 четверть координат");
if (x>0 & y<0) Console.WriteLine("3 четверть координат");
if (x<0 & y>0) Console.WriteLine("1 четверть координат");
if (x<0 & y<0) Console.WriteLine("4 четверть координат");

