// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x>0&&y>0) Console.WriteLine("вторая четверть");
if(x>0&&y<0) Console.WriteLine("третья четверть");
if(x<0&&y>0) Console.WriteLine("первая четверть");
if(x<0&&y<0) Console.WriteLine("четвертая четверть");